namespace TheCsprojLibrary.ItemTypes
{
    public class ReferenceDisplayProxy
    {
        public ReferenceDisplayProxy(Reference original)
        {
            HintPath = original.HintPath;
            SpecificVersion = original.SpecificVersion;
            Private = original.Private;
            Name = original.Name;
            RequiredTargetFramework = original.RequiredTargetFramework;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string HintPath
        {
            get;
            set;
        }

        public bool? SpecificVersion
        {
            get;
            set;
        }

        public bool? Private
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string RequiredTargetFramework
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