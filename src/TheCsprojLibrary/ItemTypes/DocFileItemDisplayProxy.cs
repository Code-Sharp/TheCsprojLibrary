namespace TheCsprojLibrary.ItemTypes
{
    public class DocFileItemDisplayProxy
    {
        public DocFileItemDisplayProxy(DocFileItem original)
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