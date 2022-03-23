    namespace JHP4SD.GumRuntimes
    {
        #region State Enums
        public enum ListBoxBehaviorListBoxCategory
        {
            Enabled,
            Disabled,
            Focused
        }
        #endregion
        public interface IListBoxBehavior
        {
            ListBoxBehaviorListBoxCategory CurrentListBoxBehaviorListBoxCategoryState {set;}
        }
    }
