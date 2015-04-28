using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_ResolveComReferenceCacheDisplayProxy))]
    public class _ResolveComReferenceCache : ItemTypeBase
    {


        public _ResolveComReferenceCache(ProjectItem item)
            : base(item)
        {

        }

    }
}