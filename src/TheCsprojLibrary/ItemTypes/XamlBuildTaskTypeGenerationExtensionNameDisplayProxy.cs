namespace TheCsprojLibrary.ItemTypes
{
    public class XamlBuildTaskTypeGenerationExtensionNameDisplayProxy
    {
        public XamlBuildTaskTypeGenerationExtensionNameDisplayProxy(XamlBuildTaskTypeGenerationExtensionName original)
        {
            AssemblyName = original.AssemblyName;
            Visible = original.Visible;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string AssemblyName
        {
            get;
            set;
        }

        public bool? Visible
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