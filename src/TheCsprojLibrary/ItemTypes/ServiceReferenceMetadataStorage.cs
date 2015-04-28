using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ServiceReferenceMetadataStorageDisplayProxy))]
    public class ServiceReferenceMetadataStorage : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mType;

        public ServiceReferenceMetadataStorage(ProjectItem item)
            : base(item)
        {
            mType = new MetadataAccessor<string>(item, "Type");
        }

        public string Type
        {
            get { return mType.Value; }
            set { mType.Value = value; }
        }
    }
}