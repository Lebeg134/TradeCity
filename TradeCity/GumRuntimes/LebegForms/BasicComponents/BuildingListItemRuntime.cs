using JHP4SD.Lebeg134.Module.Graphics;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.Structures;
using JHP4SD.Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace JHP4SD.GumRuntimes.LebegForms.BasicComponents
{
    public enum BuildingListItemButtonState
    {
        OFF,
        BUILD,
        BUILDOFF,
        UPGRADE,
        UPGRADEOFF,
        MAXLEVEL
    }
    public partial class BuildingListItemRuntime : IUpdateable, ITickable
    {
        public Building FocusBuilding
        {
            set
            {
                _focus = value;
                Update();
            }
        }
        private Building _focus;

        BuildingListItemButtonState state = BuildingListItemButtonState.OFF;
        partial void CustomInitialize()
        {
            BuildButton.Click += BuildButton_Click;
            Update();
        }

        private void BuildButton_Click(FlatRedBall.Gui.IWindow window)
        {
            if (Player.CurrentPlayer.hasStructure(_focus))
            {
                if (_focus is CommonBuilding)
                {
                    ((CommonBuilding)_focus).levelUp();
                }
            }
            else
            {
                _focus.Build(Player.CurrentPlayer);
            }
            Update();
            Resource.updater.Update();
        }

        public void Update()
        {
            if(_focus != null)
                BuildingSprite.Texture = _focus.GetSprite().Texture;
            SetState();
            UpdateButtonVisual();
            UpdateResourceVisual();
        }
        void UpdateButtonVisual()
        {
            BuildButton.Enabled = true;
            switch (state)
            {
                case BuildingListItemButtonState.BUILDOFF:
                    BuildButton.Text = "Build";
                    BuildButton.Enabled = false;
                    break;
                case BuildingListItemButtonState.BUILD:
                    BuildButton.Text = "Build";
                    break;
                case BuildingListItemButtonState.UPGRADEOFF:
                    BuildButton.Text = "Upgrade";
                    BuildButton.Enabled = false;
                    break;
                case BuildingListItemButtonState.UPGRADE:
                    BuildButton.Text = "Upgrade";
                    break;
                case BuildingListItemButtonState.MAXLEVEL:
                    BuildButton.Text = "Max level";
                    BuildButton.Enabled = false;
                    break;
                default:
                    BuildButton.Enabled = false;
                    break;
            }
        }
        void UpdateResourceVisual()
        {
            if (_focus == null)
                return;
            while(ResourceList.Children.Count() > 0)
            {
                ResourceList.RemoveChild(ResourceList.Children.First());
            }
            foreach (Resource resource in _focus.Cost())
            {
                ResourceDisplayRuntime resDisp = new ResourceDisplayRuntime();
                resDisp.Focus = resource;
                resDisp.Width = 100;
                if (!Player.CurrentPlayer.checkResource(resource))
                {
                    resDisp.SpriteInstance.Blue = 0;
                    resDisp.SpriteInstance.Green = 0;
                }
                resDisp.Update();
                ResourceList.AddChild(resDisp);
            }
            
        }
        void SetState()
        {
            if (_focus == null)
            {
                state = BuildingListItemButtonState.OFF;
                return;
            }

            if (Player.CurrentPlayer.hasStructure(_focus))
            {
                if (_focus is CommonBuilding)
                {
                    CommonBuilding focus = (CommonBuilding)_focus;
                    if (focus.IsMaxLevel())
                    {
                        state = BuildingListItemButtonState.MAXLEVEL;
                    }
                    else if (focus.checkLevelUp())
                    {
                        state = BuildingListItemButtonState.UPGRADE;
                    }
                    else
                        state = BuildingListItemButtonState.UPGRADEOFF;
                }
                else
                {
                    state = BuildingListItemButtonState.OFF;
                }
            }
            else if (_focus.CanBeBuilt(Player.CurrentPlayer))
            {
                state = BuildingListItemButtonState.BUILD;
            }
            else
                state = BuildingListItemButtonState.BUILDOFF;

        }

        public void tick()
        {
            Update();
        }

        public void register()
        {
            Clock.Instance.Register(this);
        }
    }
}
