namespace TheCsprojLibrary.ItemTypes
{
    public class BuiltProjectOutputGroupKeyOutputDisplayProxy
    {
        public BuiltProjectOutputGroupKeyOutputDisplayProxy(BuiltProjectOutputGroupKeyOutput original)
        {
            IsKeyOutput = original.IsKeyOutput;
            FinalOutputPath = original.FinalOutputPath;
            TargetPath = original.TargetPath;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public bool? IsKeyOutput
        {
            get;
            set;
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