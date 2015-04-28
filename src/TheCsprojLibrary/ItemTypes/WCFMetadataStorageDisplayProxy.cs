namespace TheCsprojLibrary.ItemTypes
{
    public class WCFMetadataStorageDisplayProxy
    {
        public WCFMetadataStorageDisplayProxy(WCFMetadataStorage original)
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