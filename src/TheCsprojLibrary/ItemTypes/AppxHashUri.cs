using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxHashUriDisplayProxy))]
    public class AppxHashUri : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mId;

        public AppxHashUri(ProjectItem item)
            : base(item)
        {
            mId = new MetadataAccessor<string>(item, "Id");
        }

        public string Id
        {
            get { return mId.Value; }
            set { mId.Value = value; }
        }
    }
}