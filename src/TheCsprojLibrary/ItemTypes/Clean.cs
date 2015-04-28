using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(CleanDisplayProxy))]
    public class Clean : ItemTypeBase
    {


        public Clean(ProjectItem item)
            : base(item)
        {

        }

    }
}