using System;
using System.Collections.Generic;
using System.Linq;
using FlatRedBall.Screens;

namespace JHP4SD.GumRuntimes.LebegForms.ComplexComponents
{
    public partial class ScreenSelectorRuntime
    {
        //static Selection? _currentScreen = Selection.CitySelected;
        partial void CustomInitialize () 
        {
            //CurrentSelectionState = _currentScreen;
            ApplyState();
            
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
        public void MoveToState(Selection newState)
        {
            CurrentSelectionState = newState;
        }
        //public void SetSelectedIndex(int index)
        //{
        //    switch (index)
        //    {
        //        default:
        //        case 0:
        //            CurrentSelectionState = Selection.CitySelected;
        //            break;
        //        case 1:
        //            CurrentSelectionState = Selection.MapSelected;
        //            break;
        //        case 2:
        //            CurrentSelectionState = Selection.MarketSelected;
        //            break;
        //    }
        //    _currentScreen = CurrentSelectionState;
        //}

    }
}
