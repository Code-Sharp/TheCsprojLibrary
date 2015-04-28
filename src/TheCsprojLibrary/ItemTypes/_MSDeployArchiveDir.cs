using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(_MSDeployArchiveDirDisplayProxy))]
    public class _MSDeployArchiveDir : ItemTypeBase
    {


        public _MSDeployArchiveDir(ProjectItem item)
            : base(item)
        {

        }

    }
}