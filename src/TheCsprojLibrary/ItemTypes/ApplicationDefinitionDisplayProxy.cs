namespace TheCsprojLibrary.ItemTypes
{
    public class ApplicationDefinitionDisplayProxy
    {
        public ApplicationDefinitionDisplayProxy(ApplicationDefinition original)
        {
            SubType = original.SubType;
            Generator = original.Generator;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string SubType
        {
            get;
            set;
        }

        public string Generator
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