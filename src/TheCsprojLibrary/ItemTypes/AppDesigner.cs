using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppDesignerDisplayProxy))]
    public class AppDesigner : ItemTypeBase
    {


        public AppDesigner(ProjectItem item)
            : base(item)
        {

        }

    }
}