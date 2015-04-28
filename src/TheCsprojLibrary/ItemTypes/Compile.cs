using System.Diagnostics;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary.ItemTypes
{
    [DebuggerDisplay("{UnevaluatedInclude}")]
    [DebuggerTypeProxy(typeof(CompileDisplayProxy))]
    public class Compile : ItemTypeBase
    {
        private readonly MetadataAccessor<bool?> mAutoGen;
        private readonly MetadataAccessor<bool?> mDesignTime;
        private readonly MetadataAccessor<string> mDependentUpon;
        private readonly MetadataAccessor<string> mLink;
        private readonly MetadataAccessor<string> mSubType;
        private readonly MetadataAccessor<bool?> mDesignTimeSharedInput;

        public Compile(ProjectItem item)
            : base(item)
        {
            mAutoGen = new MetadataAccessor<bool?>(item, "AutoGen");
            mDesignTime = new MetadataAccessor<bool?>(item, "DesignTime");
            mDependentUpon = new MetadataAccessor<string>(item, "DependentUpon");
            mLink = new MetadataAccessor<string>(item, "Link");
            mSubType = new MetadataAccessor<string>(item, "SubType");
            mDesignTimeSharedInput = new MetadataAccessor<bool?>(item, "DesignTimeSharedInput");
        }

        public bool? AutoGen
        {
            get { return mAutoGen.Value; }
            set { mAutoGen.Value = value; }
        }

        public bool? DesignTime
        {
            get { return mDesignTime.Value; }
            set { mDesignTime.Value = value; }
        }

        public string DependentUpon
        {
            get { return mDependentUpon.Value; }
            set { mDependentUpon.Value = value; }
        }

        public string Link
        {
            get { return mLink.Value; }
            set { mLink.Value = value; }
        }

        public string SubType
        {
            get { return mSubType.Value; }
            set { mSubType.Value = value; }
        }

        public bool? DesignTimeSharedInput
        {
            get { return mDesignTimeSharedInput.Value; }
            set { mDesignTimeSharedInput.Value = value; }
        }
    }
}