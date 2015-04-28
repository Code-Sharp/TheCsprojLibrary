namespace TheCsprojLibrary.ItemTypes
{
    public class NoneDisplayProxy
    {
        public NoneDisplayProxy(None original)
        {
            CopyToOutputDirectory = original.CopyToOutputDirectory;
            Generator = original.Generator;
            LastGenOutput = original.LastGenOutput;
            DependentUpon = original.DependentUpon;
            Link = original.Link;
            SubType = original.SubType;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string CopyToOutputDirectory
        {
            get;
            set;
        }

        public string Generator
        {
            get;
            set;
        }

        public string LastGenOutput
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

        public string SubType
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