using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppConfigFileDestinationDisplayProxy))]
    public class AppConfigFileDestination : ItemTypeBase
    {


        public AppConfigFileDestination(ProjectItem item)
            : base(item)
        {

        }

    }
}