using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ContentDisplayProxy))]
    public class Content : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mCopyToOutputDirectory;
        private readonly MetadataAccessor<string> mSubType;
        private readonly MetadataAccessor<string> mDependentUpon;
        private readonly MetadataAccessor<string> mLink;

        public Content(ProjectItem item)
            : base(item)
        {
            mCopyToOutputDirectory = new MetadataAccessor<string>(item, "CopyToOutputDirectory");
            mSubType = new MetadataAccessor<string>(item, "SubType");
            mDependentUpon = new MetadataAccessor<string>(item, "DependentUpon");
            mLink = new MetadataAccessor<string>(item, "Link");
        }

        public string CopyToOutputDirectory
        {
            get { return mCopyToOutputDirectory.Value; }
            set { mCopyToOutputDirectory.Value = value; }
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
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
    }
}