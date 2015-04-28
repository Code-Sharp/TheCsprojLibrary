namespace TheCsprojLibrary.ItemTypes
{
    public class _ApplicationManifestFinalDisplayProxy
    {
        public _ApplicationManifestFinalDisplayProxy(_ApplicationManifestFinal original)
        {
            TargetPath = original.TargetPath;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string TargetPath
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