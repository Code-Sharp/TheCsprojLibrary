namespace TheCsprojLibrary.ItemTypes
{
    public class _OutputPathItemDisplayProxy
    {
        public _OutputPathItemDisplayProxy(_OutputPathItem original)
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