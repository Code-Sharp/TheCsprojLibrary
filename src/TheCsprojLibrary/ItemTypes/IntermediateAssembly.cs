using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(IntermediateAssemblyDisplayProxy))]
    public class IntermediateAssembly : ItemTypeBase
    {


        public IntermediateAssembly(ProjectItem item)
            : base(item)
        {

        }

    }
}