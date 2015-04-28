using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_IISApplicationPoolDisplayProxy))]
    public class _IISApplicationPool : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mDestinationIISApplicationPool;

        public _IISApplicationPool(ProjectItem item)
            : base(item)
        {
            mDestinationIISApplicationPool = new MetadataAccessor<string>(item, "DestinationIISApplicationPool");
        }

        public string DestinationIISApplicationPool
        {
            get { return mDestinationIISApplicationPool.Value; }
            set { mDestinationIISApplicationPool.Value = value; }
        }
    }
}