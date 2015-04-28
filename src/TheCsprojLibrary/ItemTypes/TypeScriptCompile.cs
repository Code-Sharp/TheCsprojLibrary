using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(TypeScriptCompileDisplayProxy))]
    public class TypeScriptCompile : ItemTypeBase
    {


        public TypeScriptCompile(ProjectItem item)
            : base(item)
        {

        }

    }
}