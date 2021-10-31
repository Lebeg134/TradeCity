﻿using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlueControl.Editing
{
    class CopyPasteManager
    {
        List<INameable> CopiedObjects
        {
            get; set;
        } = new List<INameable>();

        public void DoHotkeyLogic(List<INameable> selectedObjects, PositionedObject itemGrabbed)
        {
            var keyboard = FlatRedBall.Input.InputManager.Keyboard;

            if (keyboard.IsCtrlDown)
            {
                if (keyboard.KeyPushed(Keys.C))
                {
                    CopiedObjects.Clear();
                    CopiedObjects.AddRange(selectedObjects);
                }
                if (keyboard.KeyPushed(Keys.V) && CopiedObjects != null)
                {
                    HandlePaste(itemGrabbed);
                }
            }
        }

        private void HandlePaste(PositionedObject itemGrabbed)
        {
            List<PositionedObject> newObjects = new List<PositionedObject>();
            foreach (var copiedObject in CopiedObjects)
            {
                PositionedObject instance = null;

                var copiedObjectName = copiedObject.Name;

                if (copiedObject is Circle originalCircle)
                {
                    instance = InstanceLogic.Self.HandleCreateCircleByGame(originalCircle, copiedObjectName);
                }
                else if (copiedObject is AxisAlignedRectangle originalRectangle)
                {
                    instance = InstanceLogic.Self.HandleCreateAxisAlignedRectangleByGame(originalRectangle, copiedObjectName);
                }
                else if (copiedObject is Polygon originalPolygon)
                {
                    instance = InstanceLogic.Self.HandleCreatePolygonByGame(originalPolygon, copiedObjectName);
                }
                else if (copiedObject is Sprite originalSprite)
                {
                    instance = InstanceLogic.Self.HandleCreateSpriteByName(originalSprite, copiedObjectName);
                }
                else if (copiedObject is Text originalText)
                {
                    instance = InstanceLogic.Self.HandleCreateTextByName(originalText, copiedObjectName);
                }
                else if (copiedObject is PositionedObject asPositionedObject) // positioned object, so entity?
                {
                    var type = copiedObject.GetType().FullName;
                    if (copiedObject is Runtime.DynamicEntity dynamicEntity)
                    {
                        type = dynamicEntity.EditModeType;
                    }
                    // for now assume names are unique, not qualified
                    instance = InstanceLogic.Self.CreateInstanceByGame(
                        type,
                        asPositionedObject);
                    instance.CreationSource = "Glue";
                    instance.Velocity = Vector3.Zero;
                    instance.Acceleration = Vector3.Zero;

                    // apply any changes that have been made to the entity:
                    int currentAddObjectIndex = CommandReceiver.GlobalGlueToGameCommands.Count;

                    for (int i = 0; i < currentAddObjectIndex; i++)
                    {
                        var dto = CommandReceiver.GlobalGlueToGameCommands[i];
                        if (dto is Dtos.AddObjectDto addObjectDtoRerun)
                        {
                            InstanceLogic.Self.HandleCreateInstanceCommandFromGlue(addObjectDtoRerun, currentAddObjectIndex, instance);
                        }
                        else if (dto is Dtos.GlueVariableSetData glueVariableSetDataRerun)
                        {
                            GlueControl.Editing.VariableAssignmentLogic.SetVariable(glueVariableSetDataRerun, instance);
                        }
                    }
                }

                if (instance != null)
                {
                    newObjects.Add(instance);
                }
            }

            // If the user is dragging objects around and pasting them, then we won't select
            // pasted objects. If the user does a simple copy/paste without dragging, then select
            // the new object.
            var shouldSelectNewObjectsInGame = itemGrabbed == null;

            if (shouldSelectNewObjectsInGame)
            {
                var isFirst = true;
                foreach (var newObject in newObjects)
                {
                    EditingManager.Self.Select(newObject.Name, addToExistingSelection: !isFirst);
                    isFirst = false;
                }
            }
            else
            {
                if (CopiedObjects.Count > 0)
                {
                    // If at least one object was copied, then we sent that one object over to Glue. Glue will
                    // automatically select newly-created objects, but we don't want that to happen when we copy/paste,
                    // so we re-send the select command on the first selected item. If only one item is selected, this will
                    // work perfectly. If not, then the first item is sent over, which is as good as we can do since Glue doesn't
                    // support multi-selection.
                    EditingManager.Self.RaiseObjectSelected();
                }
            }
        }
    }
}
