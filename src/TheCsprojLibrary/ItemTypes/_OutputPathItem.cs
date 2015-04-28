using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_OutputPathItemDisplayProxy))]
    public class _OutputPathItem : ItemTypeBase
    {


        public _OutputPathItem(ProjectItem item)
            : base(item)
        {

        }

    }
}