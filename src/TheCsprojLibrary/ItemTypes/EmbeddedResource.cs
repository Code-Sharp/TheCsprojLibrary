using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(EmbeddedResourceDisplayProxy))]
    public class EmbeddedResource : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mCopyToOutputDirectory;
        private readonly MetadataAccessor<string> mGenerator;
        private readonly MetadataAccessor<string> mLastGenOutput;
        private readonly MetadataAccessor<string> mSubType;
        private readonly MetadataAccessor<string> mCustomToolNamespace;
        private readonly MetadataAccessor<string> mLogicalName;
        private readonly MetadataAccessor<string> mLink;
        private readonly MetadataAccessor<string> mDependentUpon;

        public EmbeddedResource(ProjectItem item)
            : base(item)
        {
            mCopyToOutputDirectory = new MetadataAccessor<string>(item, "CopyToOutputDirectory");
            mGenerator = new MetadataAccessor<string>(item, "Generator");
            mLastGenOutput = new MetadataAccessor<string>(item, "LastGenOutput");
            mSubType = new MetadataAccessor<string>(item, "SubType");
            mCustomToolNamespace = new MetadataAccessor<string>(item, "CustomToolNamespace");
            mLogicalName = new MetadataAccessor<string>(item, "LogicalName");
            mLink = new MetadataAccessor<string>(item, "Link");
            mDependentUpon = new MetadataAccessor<string>(item, "DependentUpon");
        }

        public string CopyToOutputDirectory
        {
            get { return mCopyToOutputDirectory.Value; }
            set { mCopyToOutputDirectory.Value = value; }
        }

        public string Generator
        {
            get { return mGenerator.Value; }
            set { mGenerator.Value = value; }
        }

        public string LastGenOutput
        {
            get { return mLastGenOutput.Value; }
            set { mLastGenOutput.Value = value; }
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
        }

        public string CustomToolNamespace
        {
            get { return mCustomToolNamespace.Value; }
            set { mCustomToolNamespace.Value = value; }
        }

        public string LogicalName
        {
            get { return mLogicalName.Value; }
            set { mLogicalName.Value = value; }
        }

        public string Link
        {
            get { return mLink.Value; }
            set { mLink.Value = value; }
        }

        public string DependentUpon
        {
            get { return mDependentUpon.Value; }
            set { mDependentUpon.Value = value; }
        }
    }
}