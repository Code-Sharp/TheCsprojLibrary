namespace TheCsprojLibrary.ItemTypes
{
    public class _DeploymentManifestIconFileDisplayProxy
    {
        public _DeploymentManifestIconFileDisplayProxy(_DeploymentManifestIconFile original)
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