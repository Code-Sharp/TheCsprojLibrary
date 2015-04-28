namespace TheCsprojLibrary.ItemTypes
{
    public class AppxHashUriDisplayProxy
    {
        public AppxHashUriDisplayProxy(AppxHashUri original)
        {
            Id = original.Id;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Id
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