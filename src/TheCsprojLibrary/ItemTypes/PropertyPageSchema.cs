using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(PropertyPageSchemaDisplayProxy))]
    public class PropertyPageSchema : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mContext;

        public PropertyPageSchema(ProjectItem item)
            : base(item)
        {
            mContext = new MetadataAccessor<string>(item, "Context");
        }

        public string Context
        {
            get { return mContext.Value; }
            set { mContext.Value = value; }
        }
    }
}