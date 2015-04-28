namespace TheCsprojLibrary.ItemTypes
{
    public class _MSDeployPackageLocationDisplayProxy
    {
        public _MSDeployPackageLocationDisplayProxy(_MSDeployPackageLocation original)
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