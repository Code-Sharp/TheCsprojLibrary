namespace TheCsprojLibrary.ItemTypes
{
    public class DeployManifestDisplayProxy
    {
        public DeployManifestDisplayProxy(DeployManifest original)
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