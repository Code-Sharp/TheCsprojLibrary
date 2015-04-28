using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(FinalDocFileDisplayProxy))]
    public class FinalDocFile : ItemTypeBase
    {


        public FinalDocFile(ProjectItem item)
            : base(item)
        {

        }

    }
}