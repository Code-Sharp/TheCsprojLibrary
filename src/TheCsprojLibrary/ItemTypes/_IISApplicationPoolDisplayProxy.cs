namespace TheCsprojLibrary.ItemTypes
{
    public class _IISApplicationPoolDisplayProxy
    {
        public _IISApplicationPoolDisplayProxy(_IISApplicationPool original)
        {
            DestinationIISApplicationPool = original.DestinationIISApplicationPool;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string DestinationIISApplicationPool
        {
            get;
            set;
        }

        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}