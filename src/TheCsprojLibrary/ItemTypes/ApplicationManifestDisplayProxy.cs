namespace TheCsprojLibrary.ItemTypes
{
    public class ApplicationManifestDisplayProxy
    {
        public ApplicationManifestDisplayProxy(ApplicationManifest original)
        {
            TargetPath = original.TargetPath;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string TargetPath
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