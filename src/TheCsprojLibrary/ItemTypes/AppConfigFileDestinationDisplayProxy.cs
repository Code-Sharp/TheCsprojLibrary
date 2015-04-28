namespace TheCsprojLibrary.ItemTypes
{
    public class AppConfigFileDestinationDisplayProxy
    {
        public AppConfigFileDestinationDisplayProxy(AppConfigFileDestination original)
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