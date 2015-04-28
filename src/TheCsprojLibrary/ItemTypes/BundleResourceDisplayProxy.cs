namespace TheCsprojLibrary.ItemTypes
{
    public class BundleResourceDisplayProxy
    {
        public BundleResourceDisplayProxy(BundleResource original)
        {
            Link = original.Link;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Link
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