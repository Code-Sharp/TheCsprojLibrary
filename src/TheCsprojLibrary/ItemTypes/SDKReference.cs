using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(SDKReferenceDisplayProxy))]
    public class SDKReference : ItemTypeBase
    {


        public SDKReference(ProjectItem item)
            : base(item)
        {

        }

    }
}