namespace TheCsprojLibrary.ItemTypes
{
    public class ServiceReferenceMetadataStorageDisplayProxy
    {
        public ServiceReferenceMetadataStorageDisplayProxy(ServiceReferenceMetadataStorage original)
        {
            Type = original.Type;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Type
        {
            get;
            set;
        }

        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}