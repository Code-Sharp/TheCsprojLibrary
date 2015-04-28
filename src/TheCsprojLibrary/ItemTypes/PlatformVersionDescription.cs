using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(PlatformVersionDescriptionDisplayProxy))]
    public class PlatformVersionDescription : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mTargetPlatformIdentifier;
        private readonly MetadataAccessor<string> mTargetPlatformVersion;
        private readonly MetadataAccessor<string> mOSVersion;

        public PlatformVersionDescription(ProjectItem item)
            : base(item)
        {
            mTargetPlatformIdentifier = new MetadataAccessor<string>(item, "TargetPlatformIdentifier");
            mTargetPlatformVersion = new MetadataAccessor<string>(item, "TargetPlatformVersion");
            mOSVersion = new MetadataAccessor<string>(item, "OSVersion");
        }

        public string TargetPlatformIdentifier
        {
            get { return mTargetPlatformIdentifier.Value; }
            set { mTargetPlatformIdentifier.Value = value; }
        }

        public string TargetPlatformVersion
        {
            get { return mTargetPlatformVersion.Value; }
            set { mTargetPlatformVersion.Value = value; }
        }

        public string OSVersion
        {
            get { return mOSVersion.Value; }
            set { mOSVersion.Value = value; }
        }
    }
}