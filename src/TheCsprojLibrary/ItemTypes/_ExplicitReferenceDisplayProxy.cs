namespace TheCsprojLibrary.ItemTypes
{
    public class _ExplicitReferenceDisplayProxy
    {
        public _ExplicitReferenceDisplayProxy(_ExplicitReference original)
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