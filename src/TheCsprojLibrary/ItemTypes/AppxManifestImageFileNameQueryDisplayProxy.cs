namespace TheCsprojLibrary.ItemTypes
{
    public class AppxManifestImageFileNameQueryDisplayProxy
    {
        public AppxManifestImageFileNameQueryDisplayProxy(AppxManifestImageFileNameQuery original)
        {
            DescriptionID = original.DescriptionID;
            ExpectedScaleDimensions = original.ExpectedScaleDimensions;
            MaximumFileSize = original.MaximumFileSize;
            ExpectedTargetSizes = original.ExpectedTargetSizes;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string DescriptionID
        {
            get;
            set;
        }

        public string ExpectedScaleDimensions
        {
            get;
            set;
        }

        public int? MaximumFileSize
        {
            get;
            set;
        }

        public string ExpectedTargetSizes
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