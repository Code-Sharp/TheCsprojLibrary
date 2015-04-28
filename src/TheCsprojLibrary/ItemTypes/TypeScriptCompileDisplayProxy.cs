namespace TheCsprojLibrary.ItemTypes
{
    public class TypeScriptCompileDisplayProxy
    {
        public TypeScriptCompileDisplayProxy(TypeScriptCompile original)
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