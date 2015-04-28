using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(EntityDeployDisplayProxy))]
    public class EntityDeploy : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mGenerator;
        private readonly MetadataAccessor<string> mLastGenOutput;

        public EntityDeploy(ProjectItem item)
            : base(item)
        {
            mGenerator = new MetadataAccessor<string>(item, "Generator");
            mLastGenOutput = new MetadataAccessor<string>(item, "LastGenOutput");
        }

        public string Generator
        {
            get { return mGenerator.Value; }
            set { mGenerator.Value = value; }
        }

        public string LastGenOutput
        {
            get { return mLastGenOutput.Value; }
            set { mLastGenOutput.Value = value; }
        }
    }
}