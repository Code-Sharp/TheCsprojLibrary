using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary
{
    public class ItemTypeBase
    {
        private readonly ProjectItem mItem;

        public ItemTypeBase(ProjectItem item)
        {
            mItem = item;
        }

        internal ProjectItem Item
        {
            get
            {
                return mItem;
            }
        }

        public string UnevaluatedInclude
        {
            get { return mItem.UnevaluatedInclude; }
            set { mItem.UnevaluatedInclude = value; }
        }
    }
}