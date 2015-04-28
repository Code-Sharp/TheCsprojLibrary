namespace TheCsprojLibrary.ItemTypes
{
    public class WebPublishExtnsionsToExcludeItemDisplayProxy
    {
        public WebPublishExtnsionsToExcludeItemDisplayProxy(WebPublishExtnsionsToExcludeItem original)
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