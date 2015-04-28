using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(AppxSystemBinaryDisplayProxy))]
    public class AppxSystemBinary : ItemTypeBase
    {


        public AppxSystemBinary(ProjectItem item)
            : base(item)
        {

        }

    }
}