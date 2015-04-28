using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(WCFMetadataStorageDisplayProxy))]
    public class WCFMetadataStorage : ItemTypeBase
    {


        public WCFMetadataStorage(ProjectItem item)
            : base(item)
        {

        }

    }
}