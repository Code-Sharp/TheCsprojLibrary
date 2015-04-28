using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxManifestDisplayProxy))]
    public class AppxManifest : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mSubType;

        public AppxManifest(ProjectItem item)
            : base(item)
        {
            mSubType = new MetadataAccessor<string>(item, "SubType");
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
        }
    }
}