using Autofac;

namespace rest_api_ddd.infrastructure.cross_cutting.ioc
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}