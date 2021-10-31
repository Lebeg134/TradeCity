    namespace JHP4SD.GumRuntimes
    {
        #region State Enums
        public enum CheckBoxBehaviorCheckBoxCategory
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
        public interface ICheckBoxBehavior
        {
            CheckBoxBehaviorCheckBoxCategory CurrentCheckBoxBehaviorCheckBoxCategoryState {set;}
        }
    }
