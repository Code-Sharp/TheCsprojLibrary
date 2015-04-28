using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(PackageSourceDisplayProxy))]
    public class PackageSource : ItemTypeBase
    {


        public PackageSource(ProjectItem item)
            : base(item)
        {

        }

    }
}