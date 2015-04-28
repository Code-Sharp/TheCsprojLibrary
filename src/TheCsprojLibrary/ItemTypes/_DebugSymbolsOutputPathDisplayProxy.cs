namespace TheCsprojLibrary.ItemTypes
{
    public class _DebugSymbolsOutputPathDisplayProxy
    {
        public _DebugSymbolsOutputPathDisplayProxy(_DebugSymbolsOutputPath original)
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