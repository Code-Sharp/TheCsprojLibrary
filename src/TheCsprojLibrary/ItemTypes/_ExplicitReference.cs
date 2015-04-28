using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_ExplicitReferenceDisplayProxy))]
    public class _ExplicitReference : ItemTypeBase
    {


        public _ExplicitReference(ProjectItem item)
            : base(item)
        {

        }

    }
}