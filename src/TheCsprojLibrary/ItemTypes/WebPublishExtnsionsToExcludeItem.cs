using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(WebPublishExtnsionsToExcludeItemDisplayProxy))]
    public class WebPublishExtnsionsToExcludeItem : ItemTypeBase
    {


        public WebPublishExtnsionsToExcludeItem(ProjectItem item)
            : base(item)
        {

        }

    }
}