using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_IntermediateOutputPathItemDisplayProxy))]
    public class _IntermediateOutputPathItem : ItemTypeBase
    {


        public _IntermediateOutputPathItem(ProjectItem item)
            : base(item)
        {

        }

    }
}