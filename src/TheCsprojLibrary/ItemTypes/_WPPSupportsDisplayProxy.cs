namespace TheCsprojLibrary.ItemTypes
{
    public class _WPPSupportsDisplayProxy
    {
        public _WPPSupportsDisplayProxy(_WPPSupports original)
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