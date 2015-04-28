namespace TheCsprojLibrary.ItemTypes
{
    public class FolderDisplayProxy
    {
        public FolderDisplayProxy(Folder original)
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