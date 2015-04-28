using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(BootstrapperPackageDisplayProxy))]
    public class BootstrapperPackage : ItemTypeBase
    {
        private readonly MetadataAccessor<bool?> mVisible;
        private readonly MetadataAccessor<string> mProductName;
        private readonly MetadataAccessor<bool?> mInstall;

        public BootstrapperPackage(ProjectItem item)
            : base(item)
        {
            mVisible = new MetadataAccessor<bool?>(item, "Visible");
            mProductName = new MetadataAccessor<string>(item, "ProductName");
            mInstall = new MetadataAccessor<bool?>(item, "Install");
        }

        public bool? Visible
        {
            get { return mVisible.Value; }
            set { mVisible.Value = value; }
        }

        public string ProductName
        {
            get { return mProductName.Value; }
            set { mProductName.Value = value; }
        }

        public bool? Install
        {
            get { return mInstall.Value; }
            set { mInstall.Value = value; }
        }
    }
}