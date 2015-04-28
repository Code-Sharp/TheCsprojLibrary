namespace TheCsprojLibrary.ItemTypes
{
    public class IntermediateAssemblyDisplayProxy
    {
        public IntermediateAssemblyDisplayProxy(IntermediateAssembly original)
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