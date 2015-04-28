using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(WCFMetadataDisplayProxy))]
    public class WCFMetadata : ItemTypeBase
    {


        public WCFMetadata(ProjectItem item)
            : base(item)
        {

        }

    }
}