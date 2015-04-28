namespace TheCsprojLibrary.ItemTypes
{
    public class _UnmanagedRegistrationCacheDisplayProxy
    {
        public _UnmanagedRegistrationCacheDisplayProxy(_UnmanagedRegistrationCache original)
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