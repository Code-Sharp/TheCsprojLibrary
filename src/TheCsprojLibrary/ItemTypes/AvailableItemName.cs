using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AvailableItemNameDisplayProxy))]
    public class AvailableItemName : ItemTypeBase
    {


        public AvailableItemName(ProjectItem item)
            : base(item)
        {

        }

    }
}