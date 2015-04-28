using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(FxCopRuleAssembliesDisplayProxy))]
    public class FxCopRuleAssemblies : ItemTypeBase
    {


        public FxCopRuleAssemblies(ProjectItem item)
            : base(item)
        {

        }

    }
}