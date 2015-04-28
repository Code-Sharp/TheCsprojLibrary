namespace TheCsprojLibrary.ItemTypes
{
    public class UpToDateCheckOutputDisplayProxy
    {
        public UpToDateCheckOutputDisplayProxy(UpToDateCheckOutput original)
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