using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(XamlIntermediateAssemblyDisplayProxy))]
    public class XamlIntermediateAssembly : ItemTypeBase
    {


        public XamlIntermediateAssembly(ProjectItem item)
            : base(item)
        {

        }

    }
}