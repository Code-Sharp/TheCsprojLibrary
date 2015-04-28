using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(DocumentationProjectOutputGroupOutputDisplayProxy))]
    public class DocumentationProjectOutputGroupOutput : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mFinalOutputPath;
        private readonly MetadataAccessor<bool?> mIsKeyOutput;
        private readonly MetadataAccessor<string> mTargetPath;

        public DocumentationProjectOutputGroupOutput(ProjectItem item)
            : base(item)
        {
            mFinalOutputPath = new MetadataAccessor<string>(item, "FinalOutputPath");
            mIsKeyOutput = new MetadataAccessor<bool?>(item, "IsKeyOutput");
            mTargetPath = new MetadataAccessor<string>(item, "TargetPath");
        }

        public string FinalOutputPath
        {
            get { return mFinalOutputPath.Value; }
            set { mFinalOutputPath.Value = value; }
        }

        public bool? IsKeyOutput
        {
            get { return mIsKeyOutput.Value; }
            set { mIsKeyOutput.Value = value; }
        }

        public string TargetPath
        {
            get { return mTargetPath.Value; }
            set { mTargetPath.Value = value; }
        }
    }
}