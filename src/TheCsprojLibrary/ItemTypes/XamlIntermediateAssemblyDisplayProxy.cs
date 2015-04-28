namespace TheCsprojLibrary.ItemTypes
{
    public class XamlIntermediateAssemblyDisplayProxy
    {
        public XamlIntermediateAssemblyDisplayProxy(XamlIntermediateAssembly original)
        {
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}