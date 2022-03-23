    namespace JHP4SD.GumRuntimes
    {
        #region State Enums
        public enum RadioButtonBehaviorRadioButtonCategory
        {
            EnabledOn,
            EnabledOff,
            DisabledOn,
            DisabledOff,
            HighlightedOn,
            HighlightedOff,
            PushedOn,
            PushedOff
        }
        #endregion
        public interface IRadioButtonBehavior
        {
            RadioButtonBehaviorRadioButtonCategory CurrentRadioButtonBehaviorRadioButtonCategoryState {set;}
        }
    }
