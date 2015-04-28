namespace TheCsprojLibrary.ItemTypes
{
    public class AppxManifestDisplayProxy
    {
        public AppxManifestDisplayProxy(AppxManifest original)
        {
            SubType = original.SubType;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string SubType
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