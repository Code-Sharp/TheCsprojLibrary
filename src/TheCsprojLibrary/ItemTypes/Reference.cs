using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ReferenceDisplayProxy))]
    public class Reference : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mHintPath;
        private readonly MetadataAccessor<bool?> mSpecificVersion;
        private readonly MetadataAccessor<bool?> mPrivate;
        private readonly MetadataAccessor<string> mName;
        private readonly MetadataAccessor<string> mRequiredTargetFramework;

        public Reference(ProjectItem item)
            : base(item)
        {
            mHintPath = new MetadataAccessor<string>(item, "HintPath");
            mSpecificVersion = new MetadataAccessor<bool?>(item, "SpecificVersion");
            mPrivate = new MetadataAccessor<bool?>(item, "Private");
            mName = new MetadataAccessor<string>(item, "Name");
            mRequiredTargetFramework = new MetadataAccessor<string>(item, "RequiredTargetFramework");
        }

        public string HintPath
        {
            get { return mHintPath.Value; }
            set { mHintPath.Value = value; }
        }

        public bool? SpecificVersion
        {
            get { return mSpecificVersion.Value; }
            set { mSpecificVersion.Value = value; }
        }

        public bool? Private
        {
            get { return mPrivate.Value; }
            set { mPrivate.Value = value; }
        }

        public string Name
        {
            get { return mName.Value; }
            set { mName.Value = value; }
        }

        public string RequiredTargetFramework
        {
            get { return mRequiredTargetFramework.Value; }
            set { mRequiredTargetFramework.Value = value; }
        }
    }
}