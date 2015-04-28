using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(NoneDisplayProxy))]
    public class None : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mCopyToOutputDirectory;
        private readonly MetadataAccessor<string> mGenerator;
        private readonly MetadataAccessor<string> mLastGenOutput;
        private readonly MetadataAccessor<string> mDependentUpon;
        private readonly MetadataAccessor<string> mLink;
        private readonly MetadataAccessor<string> mSubType;

        public None(ProjectItem item)
            : base(item)
        {
            mCopyToOutputDirectory = new MetadataAccessor<string>(item, "CopyToOutputDirectory");
            mGenerator = new MetadataAccessor<string>(item, "Generator");
            mLastGenOutput = new MetadataAccessor<string>(item, "LastGenOutput");
            mDependentUpon = new MetadataAccessor<string>(item, "DependentUpon");
            mLink = new MetadataAccessor<string>(item, "Link");
            mSubType = new MetadataAccessor<string>(item, "SubType");
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

        public string DependentUpon
        {
            get { return mDependentUpon.Value; }
            set { mDependentUpon.Value = value; }
        }

        public string Link
        {
            get { return mLink.Value; }
            set { mLink.Value = value; }
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
        }
    }
}