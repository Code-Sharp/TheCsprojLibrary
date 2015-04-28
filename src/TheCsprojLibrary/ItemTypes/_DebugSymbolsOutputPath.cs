using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_DebugSymbolsOutputPathDisplayProxy))]
    public class _DebugSymbolsOutputPath : ItemTypeBase
    {


        public _DebugSymbolsOutputPath(ProjectItem item)
            : base(item)
        {

        }

    }
}