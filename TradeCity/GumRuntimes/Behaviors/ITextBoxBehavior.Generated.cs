    namespace JHP4SD.GumRuntimes
    {
        #region State Enums
        public enum TextBoxBehaviorTextBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        public enum TextBoxBehaviorLineModeCategory
        {
            Single,
            Multi
        }
        #endregion
        public interface ITextBoxBehavior
        {
            TextBoxBehaviorTextBoxCategory CurrentTextBoxBehaviorTextBoxCategoryState {set;}
            TextBoxBehaviorLineModeCategory CurrentTextBoxBehaviorLineModeCategoryState {set;}
        }
    }
