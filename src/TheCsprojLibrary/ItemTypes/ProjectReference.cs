using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(ProjectReferenceDisplayProxy))]
    public class ProjectReference : ItemTypeBase
    {
        private readonly MetadataAccessor<string> mTargets;
        private readonly MetadataAccessor<string> mOutputItemType;
        private readonly MetadataAccessor<string> mReferenceSourceTarget;
        private readonly MetadataAccessor<string> mProject;
        private readonly MetadataAccessor<string> mName;
        private readonly MetadataAccessor<bool?> mPrivate;
        private readonly MetadataAccessor<string> mPackage;

        public ProjectReference(ProjectItem item)
            : base(item)
        {
            mTargets = new MetadataAccessor<string>(item, "Targets");
            mOutputItemType = new MetadataAccessor<string>(item, "OutputItemType");
            mReferenceSourceTarget = new MetadataAccessor<string>(item, "ReferenceSourceTarget");
            mProject = new MetadataAccessor<string>(item, "Project");
            mName = new MetadataAccessor<string>(item, "Name");
            mPrivate = new MetadataAccessor<bool?>(item, "Private");
            mPackage = new MetadataAccessor<string>(item, "Package");
        }

        public string Targets
        {
            get { return mTargets.Value; }
            set { mTargets.Value = value; }
        }

        public string OutputItemType
        {
            get { return mOutputItemType.Value; }
            set { mOutputItemType.Value = value; }
        }

        public string ReferenceSourceTarget
        {
            get { return mReferenceSourceTarget.Value; }
            set { mReferenceSourceTarget.Value = value; }
        }

        public string Project
        {
            get { return mProject.Value; }
            set { mProject.Value = value; }
        }

        public string Name
        {
            get { return mName.Value; }
            set { mName.Value = value; }
        }

        public bool? Private
        {
            get { return mPrivate.Value; }
            set { mPrivate.Value = value; }
        }

        public string Package
        {
            get { return mPackage.Value; }
            set { mPackage.Value = value; }
        }
    }
}