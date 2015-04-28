namespace TheCsprojLibrary.ItemTypes
{
    public class AvailableItemNameDisplayProxy
    {
        public AvailableItemNameDisplayProxy(AvailableItemName original)
        {
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}