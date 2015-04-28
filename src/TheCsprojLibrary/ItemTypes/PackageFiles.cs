using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(PackageFilesDisplayProxy))]
    public class PackageFiles : ItemTypeBase
    {


        public PackageFiles(ProjectItem item)
            : base(item)
        {

        }

    }
}