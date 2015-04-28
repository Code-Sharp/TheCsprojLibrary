namespace TheCsprojLibrary.ItemTypes
{
    public class DebugSymbolsProjectOutputGroupOutputDisplayProxy
    {
        public DebugSymbolsProjectOutputGroupOutputDisplayProxy(DebugSymbolsProjectOutputGroupOutput original)
        {
            FinalOutputPath = original.FinalOutputPath;
            TargetPath = original.TargetPath;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string FinalOutputPath
        {
            get;
            set;
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