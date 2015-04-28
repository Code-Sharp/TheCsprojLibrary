using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(DocFileItemDisplayProxy))]
    public class DocFileItem : ItemTypeBase
    {


        public DocFileItem(ProjectItem item)
            : base(item)
        {

        }

    }
}