using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(UpToDateCheckOutputDisplayProxy))]
    public class UpToDateCheckOutput : ItemTypeBase
    {


        public UpToDateCheckOutput(ProjectItem item)
            : base(item)
        {

        }

    }
}