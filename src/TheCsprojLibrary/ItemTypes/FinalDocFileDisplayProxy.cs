namespace TheCsprojLibrary.ItemTypes
{
    public class FinalDocFileDisplayProxy
    {
        public FinalDocFileDisplayProxy(FinalDocFile original)
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