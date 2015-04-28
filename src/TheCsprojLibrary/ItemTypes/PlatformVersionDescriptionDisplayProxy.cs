namespace TheCsprojLibrary.ItemTypes
{
    public class PlatformVersionDescriptionDisplayProxy
    {
        public PlatformVersionDescriptionDisplayProxy(PlatformVersionDescription original)
        {
            TargetPlatformIdentifier = original.TargetPlatformIdentifier;
            TargetPlatformVersion = original.TargetPlatformVersion;
            OSVersion = original.OSVersion;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string TargetPlatformIdentifier
        {
            get;
            set;
        }

        public string TargetPlatformVersion
        {
            get;
            set;
        }

        public string OSVersion
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