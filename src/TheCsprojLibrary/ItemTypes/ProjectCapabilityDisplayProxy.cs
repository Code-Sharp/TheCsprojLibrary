namespace TheCsprojLibrary.ItemTypes
{
    public class ProjectCapabilityDisplayProxy
    {
        public ProjectCapabilityDisplayProxy(ProjectCapability original)
        {
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string UnevaluatedInclude
        {
            get;
            set;
        }
    }
}