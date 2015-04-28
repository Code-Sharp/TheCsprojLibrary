namespace TheCsprojLibrary.ItemTypes
{
    public class TargetPlatformDisplayProxy
    {
        public TargetPlatformDisplayProxy(TargetPlatform original)
        {
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}