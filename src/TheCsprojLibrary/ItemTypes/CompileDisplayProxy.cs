namespace TheCsprojLibrary.ItemTypes
{
    public class CompileDisplayProxy
    {
        public CompileDisplayProxy(Compile original)
        {
            AutoGen = original.AutoGen;
            DesignTime = original.DesignTime;
            DependentUpon = original.DependentUpon;
            Link = original.Link;
            SubType = original.SubType;
            DesignTimeSharedInput = original.DesignTimeSharedInput;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public bool? AutoGen
        {
            get;
            set;
        }

        public bool? DesignTime
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

        public bool? DesignTimeSharedInput
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