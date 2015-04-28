namespace TheCsprojLibrary.ItemTypes
{
    public class AppxSystemBinaryDisplayProxy
    {
        public AppxSystemBinaryDisplayProxy(AppxSystemBinary original)
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