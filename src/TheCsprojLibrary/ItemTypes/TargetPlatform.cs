using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(TargetPlatformDisplayProxy))]
    public class TargetPlatform : ItemTypeBase
    {


        public TargetPlatform(ProjectItem item)
            : base(item)
        {

        }

    }
}