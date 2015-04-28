using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxManifestFileNameQueryDisplayProxy))]
    public class AppxManifestFileNameQuery : ItemTypeBase
    {


        public AppxManifestFileNameQuery(ProjectItem item)
            : base(item)
        {

        }

    }
}