namespace TheCsprojLibrary.ItemTypes
{
    public class WCFMetadataDisplayProxy
    {
        public WCFMetadataDisplayProxy(WCFMetadata original)
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