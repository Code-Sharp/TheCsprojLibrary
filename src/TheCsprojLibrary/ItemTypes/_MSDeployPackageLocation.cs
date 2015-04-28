using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_MSDeployPackageLocationDisplayProxy))]
    public class _MSDeployPackageLocation : ItemTypeBase
    {


        public _MSDeployPackageLocation(ProjectItem item)
            : base(item)
        {

        }

    }
}