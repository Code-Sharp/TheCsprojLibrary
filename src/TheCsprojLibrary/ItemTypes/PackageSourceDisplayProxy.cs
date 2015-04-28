namespace TheCsprojLibrary.ItemTypes
{
    public class PackageSourceDisplayProxy
    {
        public PackageSourceDisplayProxy(PackageSource original)
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