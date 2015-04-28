using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(BundleResourceDisplayProxy))]
    public class BundleResource : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mLink;

        public BundleResource(ProjectItem item)
            : base(item)
        {
            mLink = new MetadataAccessor<string>(item, "Link");
        }

        public string Link
        {
            get { return mLink.Value; }
            set { mLink.Value = value; }
        }
    }
}