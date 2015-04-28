using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxManifestImageFileNameQueryDisplayProxy))]
    public class AppxManifestImageFileNameQuery : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mDescriptionID;
        private readonly MetadataAccessor<string> mExpectedScaleDimensions;
        private readonly MetadataAccessor<int?> mMaximumFileSize;
        private readonly MetadataAccessor<string> mExpectedTargetSizes;

        public AppxManifestImageFileNameQuery(ProjectItem item)
            : base(item)
        {
            mDescriptionID = new MetadataAccessor<string>(item, "DescriptionID");
            mExpectedScaleDimensions = new MetadataAccessor<string>(item, "ExpectedScaleDimensions");
            mMaximumFileSize = new MetadataAccessor<int?>(item, "MaximumFileSize");
            mExpectedTargetSizes = new MetadataAccessor<string>(item, "ExpectedTargetSizes");
        }

        public string DescriptionID
        {
            get { return mDescriptionID.Value; }
            set { mDescriptionID.Value = value; }
        }

        public string ExpectedScaleDimensions
        {
            get { return mExpectedScaleDimensions.Value; }
            set { mExpectedScaleDimensions.Value = value; }
        }

        public int? MaximumFileSize
        {
            get { return mMaximumFileSize.Value; }
            set { mMaximumFileSize.Value = value; }
        }

        public string ExpectedTargetSizes
        {
            get { return mExpectedTargetSizes.Value; }
            set { mExpectedTargetSizes.Value = value; }
        }
    }
}