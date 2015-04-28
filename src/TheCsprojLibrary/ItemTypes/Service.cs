using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ServiceDisplayProxy))]
    public class Service : ItemTypeBase
    {


        public Service(ProjectItem item)
            : base(item)
        {

        }

    }
}