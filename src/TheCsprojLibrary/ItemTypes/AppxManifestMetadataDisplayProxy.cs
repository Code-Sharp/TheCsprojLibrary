namespace TheCsprojLibrary.ItemTypes
{
    public class AppxManifestMetaDataDisplayProxy
    {
        public AppxManifestMetaDataDisplayProxy(AppxManifestMetaData original)
        {
            Value = original.Value;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Value
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

    public class AppxManifestMetadataDisplayProxy
    {
        public AppxManifestMetadataDisplayProxy(AppxManifestMetadata original)
        {
            Value = original.Value;
            Version = original.Version;
            Name = original.Name;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Value
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public string Name
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