using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(XamlBuildTaskTypeGenerationExtensionNameDisplayProxy))]
    public class XamlBuildTaskTypeGenerationExtensionName : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mAssemblyName;
        private readonly MetadataAccessor<bool?> mVisible;

        public XamlBuildTaskTypeGenerationExtensionName(ProjectItem item)
            : base(item)
        {
            mAssemblyName = new MetadataAccessor<string>(item, "AssemblyName");
            mVisible = new MetadataAccessor<bool?>(item, "Visible");
        }

        public string AssemblyName
        {
            get { return mAssemblyName.Value; }
            set { mAssemblyName.Value = value; }
        }

        public bool? Visible
        {
            get { return mVisible.Value; }
            set { mVisible.Value = value; }
        }
    }
}