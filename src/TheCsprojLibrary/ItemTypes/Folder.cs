using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(FolderDisplayProxy))]
    public class Folder : ItemTypeBase
    {


        public Folder(ProjectItem item)
            : base(item)
        {

        }

    }
}