using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(BuiltProjectOutputGroupKeyOutputDisplayProxy))]
    public class BuiltProjectOutputGroupKeyOutput : ItemTypeBase
    {
        private readonly MetadataAccessor<bool?> mIsKeyOutput;
        private readonly MetadataAccessor<string> mFinalOutputPath;
        private readonly MetadataAccessor<string> mTargetPath;

        public BuiltProjectOutputGroupKeyOutput(ProjectItem item)
            : base(item)
        {
            mIsKeyOutput = new MetadataAccessor<bool?>(item, "IsKeyOutput");
            mFinalOutputPath = new MetadataAccessor<string>(item, "FinalOutputPath");
            mTargetPath = new MetadataAccessor<string>(item, "TargetPath");
        }

        public bool? IsKeyOutput
        {
            get { return mIsKeyOutput.Value; }
            set { mIsKeyOutput.Value = value; }
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