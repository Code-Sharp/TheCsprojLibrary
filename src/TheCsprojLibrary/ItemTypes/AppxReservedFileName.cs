using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxReservedFileNameDisplayProxy))]
    public class AppxReservedFileName : ItemTypeBase
    {


        public AppxReservedFileName(ProjectItem item)
            : base(item)
        {

        }

    }
}