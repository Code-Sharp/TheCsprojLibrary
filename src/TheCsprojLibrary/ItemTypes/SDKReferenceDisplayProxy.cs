namespace TheCsprojLibrary.ItemTypes
{
    public class SDKReferenceDisplayProxy
    {
        public SDKReferenceDisplayProxy(SDKReference original)
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