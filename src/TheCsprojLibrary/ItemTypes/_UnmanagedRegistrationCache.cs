using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_UnmanagedRegistrationCacheDisplayProxy))]
    public class _UnmanagedRegistrationCache : ItemTypeBase
    {


        public _UnmanagedRegistrationCache(ProjectItem item)
            : base(item)
        {

        }

    }
}