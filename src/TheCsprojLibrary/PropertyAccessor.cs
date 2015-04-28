using System;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary
{
    internal class PropertyAccessor<T>
    {
        private readonly Project mProject;
        private readonly string mPropertyName;

        public PropertyAccessor(Project project, string propertyName)
        {
            mProject = project;
            mPropertyName = propertyName;
        }

        public T Value
        {
            get
            {
                ProjectProperty projectProperty = mProject.GetProperty(mPropertyName);

                if (projectProperty != null)
                {
                    return (T)Convert.ChangeType(projectProperty.UnevaluatedValue, TypeExtensions.GetUnderlyingType<T>());                    
                }

                return default(T);
            }
            set
            {
                if (value != null)
                {
                    mProject.SetProperty(mPropertyName, Convert.ToString(value));                    
                }
                else
                {
                    ProjectProperty property = mProject.GetProperty(mPropertyName);

                    if (property != null)
                    {
                        mProject.RemoveProperty(property);
                    }
                }
            }
        }
    }
}