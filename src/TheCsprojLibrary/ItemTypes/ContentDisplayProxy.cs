namespace TheCsprojLibrary.ItemTypes
{
    public class ContentDisplayProxy
    {
        public ContentDisplayProxy(Content original)
        {
            CopyToOutputDirectory = original.CopyToOutputDirectory;
            SubType = original.SubType;
            DependentUpon = original.DependentUpon;
            Link = original.Link;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string CopyToOutputDirectory
        {
            get;
            set;
        }

        public string SubType
        {
            get;
            set;
        }

        public string DependentUpon
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