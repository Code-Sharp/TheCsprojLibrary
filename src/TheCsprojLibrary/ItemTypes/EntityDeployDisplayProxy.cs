namespace TheCsprojLibrary.ItemTypes
{
    public class EntityDeployDisplayProxy
    {
        public EntityDeployDisplayProxy(EntityDeploy original)
        {
            Generator = original.Generator;
            LastGenOutput = original.LastGenOutput;
            UnevaluatedInclude = original.UnevaluatedInclude;
        }


        public string Generator
        {
            get;
            set;
        }

        public string LastGenOutput
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