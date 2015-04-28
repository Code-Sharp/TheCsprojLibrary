using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(DebugSymbolsProjectOutputGroupOutputDisplayProxy))]
    public class DebugSymbolsProjectOutputGroupOutput : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mFinalOutputPath;
        private readonly MetadataAccessor<string> mTargetPath;

        public DebugSymbolsProjectOutputGroupOutput(ProjectItem item)
            : base(item)
        {
            mFinalOutputPath = new MetadataAccessor<string>(item, "FinalOutputPath");
            mTargetPath = new MetadataAccessor<string>(item, "TargetPath");
        }

        public string FinalOutputPath
        {
            get { return mFinalOutputPath.Value; }
            set { mFinalOutputPath.Value = value; }
        }

        public string TargetPath
        {
            get { return mTargetPath.Value; }
            set { mTargetPath.Value = value; }
        }
    }
}