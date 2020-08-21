using rest_api_ddd.domain.core.interfaces.repositories;
using rest_api_ddd.domain.core.interfaces.services;
using rest_api_ddd.domain.entitys;

namespace rest_api_ddd.domain.services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}