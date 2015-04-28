namespace TheCsprojLibrary.ItemTypes
{
    public class EmbeddedResourceDisplayProxy
    {
        public EmbeddedResourceDisplayProxy(EmbeddedResource original)
        {
            CopyToOutputDirectory = original.CopyToOutputDirectory;
            Generator = original.Generator;
            LastGenOutput = original.LastGenOutput;
            SubType = original.SubType;
            CustomToolNamespace = original.CustomToolNamespace;
            LogicalName = original.LogicalName;
            Link = original.Link;
            DependentUpon = original.DependentUpon;
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

        public string SubType
        {
            get;
            set;
        }

        public string CustomToolNamespace
        {
            get;
            set;
        }

        public string LogicalName
        {
            get;
            set;
        }

        public string Link
        {
            get;
            set;
        }

        public string DependentUpon
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