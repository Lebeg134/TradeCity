using System;
using System.Collections.Generic;
using System.Linq;
using FlatRedBall.Screens;

namespace JHP4SD.GumRuntimes.LebegForms.ComplexComponents
{
    public partial class ScreenSelectorRuntime
    {
        static Selection? _currentScreen = Selection.CitySelected;
        partial void CustomInitialize () 
        {
            MoveToState(_currentScreen);

            CityTab.Click += CityTab_Click;
            MapTab.Click += MapTab_Click;
            MarketTab.Click += MarketTab_Click;
        }
        private void CityTab_Click(FlatRedBall.Gui.IWindow window)
        {
            MoveToState(Selection.CitySelected);
        }
        private void MapTab_Click(FlatRedBall.Gui.IWindow window)
        {
            MoveToState(Selection.MapSelected);
        }
        private void MarketTab_Click(FlatRedBall.Gui.IWindow window)
        {
            MoveToState(Selection.MarketSelected);
        }

        public void ApplyState()
        {
            CityTab.Enabled = true;
            MapTab.Enabled = true;
            MarketTab.Enabled = true;
            switch (CurrentSelectionState)
            {
                case Selection.CitySelected:
                    CityTab.Enabled = false;
                    break;
                case Selection.MapSelected:
                    MapTab.Enabled = false;
                    break;
                case Selection.MarketSelected:
                    MarketTab.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        public void MoveToState(Selection? newState)
        {
            _currentScreen = newState;
            CurrentSelectionState = _currentScreen;
            ApplyState();
        }
    }
}
