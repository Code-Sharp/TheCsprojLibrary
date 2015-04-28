namespace TheCsprojLibrary.ItemTypes
{
    public class FxCopRuleAssembliesDisplayProxy
    {
        public FxCopRuleAssembliesDisplayProxy(FxCopRuleAssemblies original)
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