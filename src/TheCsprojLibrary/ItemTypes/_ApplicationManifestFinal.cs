using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_ApplicationManifestFinalDisplayProxy))]
    public class _ApplicationManifestFinal : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mTargetPath;

        public _ApplicationManifestFinal(ProjectItem item)
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