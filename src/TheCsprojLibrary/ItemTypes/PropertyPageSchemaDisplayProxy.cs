namespace TheCsprojLibrary.ItemTypes
{
    public class PropertyPageSchemaDisplayProxy
    {
        public PropertyPageSchemaDisplayProxy(PropertyPageSchema original)
        {
            Context = original.Context;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Context
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