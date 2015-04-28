namespace TheCsprojLibrary.ItemTypes
{
    public class _MSDeployArchiveDirDisplayProxy
    {
        public _MSDeployArchiveDirDisplayProxy(_MSDeployArchiveDir original)
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