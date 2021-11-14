#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace JHP4SD.Screens
{
    public partial class Level3 : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static JHP4SD.GumRuntimes.Level3GumRuntime Level3Gum;
        protected static FlatRedBall.TileGraphics.LayeredTileMap Level3Map;
        
        private JHP4SD.Entities.CameraMidpoint CameraMidpointInstance;
        private FlatRedBall.Entities.CameraControllingEntity CameraControllingEntityInstance;
        private FlatRedBall.TileCollisions.TileShapeCollection SolidCollision;
        private FlatRedBall.Math.Collision.CollidableVsTileShapeCollectionRelationship<JHP4SD.Entities.CameraMidpoint> CameraMidpointInstanceVsSolidCollision;
        JHP4SD.FormsControls.Screens.Level3GumForms Forms;
        JHP4SD.GumRuntimes.Level3GumRuntime GumScreen;
        public Level3 () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = Level3Map;
            CameraMidpointInstance = new JHP4SD.Entities.CameraMidpoint(ContentManagerName, false);
            CameraMidpointInstance.Name = "CameraMidpointInstance";
            CameraMidpointInstance.CreationSource = "Glue";
            CameraControllingEntityInstance = new FlatRedBall.Entities.CameraControllingEntity();
            CameraControllingEntityInstance.Name = "CameraControllingEntityInstance";
            CameraControllingEntityInstance.CreationSource = "Glue";
            SolidCollision = new FlatRedBall.TileCollisions.TileShapeCollection(); SolidCollision.Name = "SolidCollision";
                if (SolidCollision != null)
    {
        CameraMidpointInstanceVsSolidCollision = FlatRedBall.Math.Collision.CollisionManagerTileShapeCollectionExtensions.CreateTileRelationship(FlatRedBall.Math.Collision.CollisionManager.Self, CameraMidpointInstance, SolidCollision);
        CameraMidpointInstanceVsSolidCollision.Name = "CameraMidpointInstanceVsSolidCollision";
        CameraMidpointInstanceVsSolidCollision.SetMoveCollision(0f, 1f);
    }

            Forms = new JHP4SD.FormsControls.Screens.Level3GumForms(Level3Gum);
            GumScreen = Level3Gum;
            FillCollisionForSolidCollision();
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            Level3Gum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            Level3Map.AddToManagers(mLayer);
            CameraMidpointInstance.AddToManagers(mLayer);
            FlatRedBall.SpriteManager.AddPositionedObject(CameraControllingEntityInstance); CameraControllingEntityInstance.Activity();
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                Level3Map?.AnimateSelf();;
                CameraMidpointInstance.Activity();
                CameraControllingEntityInstance.Activity();
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void ActivityEditMode () 
        {
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode)
            {
                CameraMidpointInstance.ActivityEditMode();
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Level3Gum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            Level3Gum = null;
            Level3Map.Destroy();
            Level3Map = null;
            
            if (CameraMidpointInstance != null)
            {
                CameraMidpointInstance.Destroy();
                CameraMidpointInstance.Detach();
            }
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
            if (Map != null)
            {
                Map.Destroy();
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (CameraMidpointInstance.Parent == null)
            {
                CameraMidpointInstance.X = 200f;
            }
            else
            {
                CameraMidpointInstance.RelativeX = 200f;
            }
            if (CameraMidpointInstance.Parent == null)
            {
                CameraMidpointInstance.Y = -200f;
            }
            else
            {
                CameraMidpointInstance.RelativeY = -200f;
            }
            CameraControllingEntityInstance.Targets.Clear(); CameraControllingEntityInstance.Targets.Add(CameraMidpointInstance);
            CameraControllingEntityInstance.Map = Map;
            CameraControllingEntityInstance.LerpSmooth = false;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            Level3Gum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            Level3Map.Destroy();
            CameraMidpointInstance.RemoveFromManagers();
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
            if (Map != null)
            {
                Map.Destroy();
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
                CameraMidpointInstance.AssignCustomVariables(true);
            }
            if (CameraMidpointInstance.Parent == null)
            {
                CameraMidpointInstance.X = 200f;
            }
            else
            {
                CameraMidpointInstance.RelativeX = 200f;
            }
            if (CameraMidpointInstance.Parent == null)
            {
                CameraMidpointInstance.Y = -200f;
            }
            else
            {
                CameraMidpointInstance.RelativeY = -200f;
            }
            CameraControllingEntityInstance.Targets.Clear(); CameraControllingEntityInstance.Targets.Add(CameraMidpointInstance);
            CameraControllingEntityInstance.Map = Map;
            CameraControllingEntityInstance.LerpSmooth = false;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            CameraMidpointInstance.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            JHP4SD.Screens.GameScreen.LoadStaticContent(contentManagerName);
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            if(Level3Gum == null) Level3Gum = (JHP4SD.GumRuntimes.Level3GumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("Level3Gum"), true);
            Level3Map = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/level3/level3map.tmx", contentManagerName);
            JHP4SD.Entities.CameraMidpoint.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level3Gum":
                    return Level3Gum;
                case  "Level3Map":
                    return Level3Map;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Level3Gum":
                    return Level3Gum;
                case  "Level3Map":
                    return Level3Map;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level3Gum":
                    return Level3Gum;
                case  "Level3Map":
                    return Level3Map;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            Level3Gum.UpdateLayout();
        }
        protected virtual void FillCollisionForSolidCollision () 
        {
            if (SolidCollision != null)
            {
                // normally we wait to set variables until after the object is created, but in this case if the
                // TileShapeCollection doesn't have its Visible set before creating the tiles, it can result in
                // really bad performance issues, as shapes will be made visible, then invisible. Really bad perf!
                SolidCollision.Visible = false;
                FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(SolidCollision, Map, "SolidCollision", false);
            }
        }
        partial void CustomActivityEditMode();
    }
}
