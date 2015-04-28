using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ProjectCapabilityDisplayProxy))]
    public class ProjectCapability : ItemTypeBase
    {


        public ProjectCapability(ProjectItem item)
            : base(item)
        {

        }

    }
}