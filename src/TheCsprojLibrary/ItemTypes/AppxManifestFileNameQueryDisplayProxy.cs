namespace TheCsprojLibrary.ItemTypes
{
    public class AppxManifestFileNameQueryDisplayProxy
    {
        public AppxManifestFileNameQueryDisplayProxy(AppxManifestFileNameQuery original)
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