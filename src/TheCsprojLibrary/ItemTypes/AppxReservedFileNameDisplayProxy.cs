namespace TheCsprojLibrary.ItemTypes
{
    public class AppxReservedFileNameDisplayProxy
    {
        public AppxReservedFileNameDisplayProxy(AppxReservedFileName original)
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