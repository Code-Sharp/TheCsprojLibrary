using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_DebugSymbolsIntermediatePathDisplayProxy))]
    public class _DebugSymbolsIntermediatePath : ItemTypeBase
    {


        public _DebugSymbolsIntermediatePath(ProjectItem item)
            : base(item)
        {

        }

    }
}