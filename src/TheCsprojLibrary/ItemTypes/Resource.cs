using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ResourceDisplayProxy))]
    public class Resource : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mSubType;
        private readonly MetadataAccessor<string> mGenerator;
        private readonly MetadataAccessor<string> mLink;

        public Resource(ProjectItem item)
            : base(item)
        {
            mSubType = new MetadataAccessor<string>(item, "SubType");
            mGenerator = new MetadataAccessor<string>(item, "Generator");
            mLink = new MetadataAccessor<string>(item, "Link");
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
        }

        public string Generator
        {
            get { return mGenerator.Value; }
            set { mGenerator.Value = value; }
        }

        public string Link
        {
            get { return mLink.Value; }
            set { mLink.Value = value; }
        }
    }
}