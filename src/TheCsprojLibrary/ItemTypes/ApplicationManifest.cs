using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ApplicationManifestDisplayProxy))]
    public class ApplicationManifest : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mTargetPath;

        public ApplicationManifest(ProjectItem item)
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