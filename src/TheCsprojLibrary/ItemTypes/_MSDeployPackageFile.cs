using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_MSDeployPackageFileDisplayProxy))]
    public class _MSDeployPackageFile : ItemTypeBase
    {


        public _MSDeployPackageFile(ProjectItem item)
            : base(item)
        {

        }

    }
}