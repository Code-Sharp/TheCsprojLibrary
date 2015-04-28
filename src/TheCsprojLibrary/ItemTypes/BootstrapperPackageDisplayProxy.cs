namespace TheCsprojLibrary.ItemTypes
{
    public class BootstrapperPackageDisplayProxy
    {
        public BootstrapperPackageDisplayProxy(BootstrapperPackage original)
        {
            Visible = original.Visible;
            ProductName = original.ProductName;
            Install = original.Install;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public bool? Visible
        {
            get;
            set;
        }

        public string ProductName
        {
            get;
            set;
        }

        public bool? Install
        {
            get;
            set;
        }

        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}