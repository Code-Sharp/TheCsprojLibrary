namespace TheCsprojLibrary.ItemTypes
{
    public class PackageFilesDisplayProxy
    {
        public PackageFilesDisplayProxy(PackageFiles original)
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