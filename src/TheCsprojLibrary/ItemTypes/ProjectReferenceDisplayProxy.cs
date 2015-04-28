namespace TheCsprojLibrary.ItemTypes
{
    public class ProjectReferenceDisplayProxy
    {
        public ProjectReferenceDisplayProxy(ProjectReference original)
        {
            Targets = original.Targets;
            OutputItemType = original.OutputItemType;
            ReferenceSourceTarget = original.ReferenceSourceTarget;
            Project = original.Project;
            Name = original.Name;
            Private = original.Private;
            Package = original.Package;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Targets
        {
            get;
            set;
        }

        public string OutputItemType
        {
            get;
            set;
        }

        public string ReferenceSourceTarget
        {
            get;
            set;
        }

        public string Project
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public bool? Private
        {
            get;
            set;
        }

        public string Package
        {
            get;
            set;
        }

        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}