namespace TheCsprojLibrary.ItemTypes
{
    public class ServiceDisplayProxy
    {
        public ServiceDisplayProxy(Service original)
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