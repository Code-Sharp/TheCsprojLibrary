namespace TheCsprojLibrary.ItemTypes
{
    public class _DeploymentManifestEntryPointDisplayProxy
    {
        public _DeploymentManifestEntryPointDisplayProxy(_DeploymentManifestEntryPoint original)
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