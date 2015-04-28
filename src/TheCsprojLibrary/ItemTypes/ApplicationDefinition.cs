using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ApplicationDefinitionDisplayProxy))]
    public class ApplicationDefinition : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mSubType;
        private readonly MetadataAccessor<string> mGenerator;

        public ApplicationDefinition(ProjectItem item)
            : base(item)
        {
            mSubType = new MetadataAccessor<string>(item, "SubType");
            mGenerator = new MetadataAccessor<string>(item, "Generator");
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
        }

        public string Generator
        {
            get { return mGenerator.Value; }
            set { mGenerator.Value = value; }
        }
    }
}