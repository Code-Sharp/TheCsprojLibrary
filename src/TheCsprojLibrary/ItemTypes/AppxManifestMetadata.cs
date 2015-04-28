using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxManifestMetaDataDisplayProxy))]
    public class AppxManifestMetaData : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mValue;

        public AppxManifestMetaData(ProjectItem item)
            : base(item)
        {
            mValue = new MetadataAccessor<string>(item, "Value");
        }

        public string Value
        {
            get { return mValue.Value; }
            set { mValue.Value = value; }
        }
    }

    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxManifestMetadataDisplayProxy))]
    public class AppxManifestMetadata : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mValue;
        private readonly MetadataAccessor<string> mVersion;
        private readonly MetadataAccessor<string> mName;

        public AppxManifestMetadata(ProjectItem item)
            : base(item)
        {
            mValue = new MetadataAccessor<string>(item, "Value");
            mVersion = new MetadataAccessor<string>(item, "Version");
            mName = new MetadataAccessor<string>(item, "Name");
        }

        public string Value
        {
            get { return mValue.Value; }
            set { mValue.Value = value; }
        }

        public string Version
        {
            get { return mVersion.Value; }
            set { mVersion.Value = value; }
        }

        public string Name
        {
            get { return mName.Value; }
            set { mName.Value = value; }
        }
    }
}