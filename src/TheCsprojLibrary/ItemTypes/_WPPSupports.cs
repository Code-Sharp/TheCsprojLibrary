using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_WPPSupportsDisplayProxy))]
    public class _WPPSupports : ItemTypeBase
    {


        public _WPPSupports(ProjectItem item)
            : base(item)
        {

        }

    }
}