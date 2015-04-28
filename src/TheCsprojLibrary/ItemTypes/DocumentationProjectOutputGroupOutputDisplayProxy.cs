namespace TheCsprojLibrary.ItemTypes
{
    public class DocumentationProjectOutputGroupOutputDisplayProxy
    {
        public DocumentationProjectOutputGroupOutputDisplayProxy(DocumentationProjectOutputGroupOutput original)
        {
            FinalOutputPath = original.FinalOutputPath;
            IsKeyOutput = original.IsKeyOutput;
            TargetPath = original.TargetPath;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string FinalOutputPath
        {
            get;
            set;
        }

        public bool? IsKeyOutput
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