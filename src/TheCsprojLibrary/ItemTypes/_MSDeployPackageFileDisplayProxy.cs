namespace TheCsprojLibrary.ItemTypes
{
    public class _MSDeployPackageFileDisplayProxy
    {
        public _MSDeployPackageFileDisplayProxy(_MSDeployPackageFile original)
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