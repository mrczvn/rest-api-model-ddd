using Autofac;
using rest_api_ddd.application;
using rest_api_ddd.application.interfaces;
using rest_api_ddd.application.interfaces.mappers;
using rest_api_ddd.application.mappers;
using rest_api_ddd.domain.core.interfaces.repositories;
using rest_api_ddd.domain.core.interfaces.services;
using rest_api_ddd.domain.services;
using rest_api_ddd.infrastructure.data.repositorys;

namespace rest_api_ddd.infrastructure.cross_cutting.ioc
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion IOC
        }
    }
}