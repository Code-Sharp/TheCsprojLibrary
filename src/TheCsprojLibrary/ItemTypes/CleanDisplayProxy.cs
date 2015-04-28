namespace TheCsprojLibrary.ItemTypes
{
    public class CleanDisplayProxy
    {
        public CleanDisplayProxy(Clean original)
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