namespace TheCsprojLibrary.ItemTypes
{
    public class PageDisplayProxy
    {
        public PageDisplayProxy(Page original)
        {
            SubType = original.SubType;
            Generator = original.Generator;
            Link = original.Link;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string SubType
        {
            get;
            set;
        }

        public string Generator
        {
            get;
            set;
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