namespace TheCsprojLibrary.ItemTypes
{
    public class AppDesignerDisplayProxy
    {
        public AppDesignerDisplayProxy(AppDesigner original)
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