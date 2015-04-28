using System;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary
{
    internal class MetadataAccessor<T>
    {
        private readonly ProjectItem mOwner;
        private readonly string mMetadataName;

        public MetadataAccessor(ProjectItem owner, string metadataName)
        {
            mOwner = owner;
            mMetadataName = metadataName;
        }

        public T Value
        {
            get
            {
                ProjectMetadata metadata = mOwner.GetMetadata(mMetadataName);

                if (metadata != null)
                {
                    return (T)Convert.ChangeType(metadata.UnevaluatedValue, TypeExtensions.GetUnderlyingType<T>());
                }

                return default(T);
            }
            set
            {
                if (value == null)
                {
                    mOwner.RemoveMetadata(mMetadataName);
                }
                else
                {
                    string unevaluatedValue = Convert.ToString(value);

                    mOwner.SetMetadataValue(mMetadataName, unevaluatedValue);
                }
            }
        }
    }
}