using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_DeploymentManifestEntryPointDisplayProxy))]
    public class _DeploymentManifestEntryPoint : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mTargetPath;

        public _DeploymentManifestEntryPoint(ProjectItem item)
            : base(item)
        {
            mTargetPath = new MetadataAccessor<string>(item, "TargetPath");
        }

        public string TargetPath
        {
            get { return mTargetPath.Value; }
            set { mTargetPath.Value = value; }
        }
    }
}