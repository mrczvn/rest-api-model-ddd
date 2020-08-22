using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces;
using rest_api_ddd.application.interfaces.mappers;
using rest_api_ddd.domain.core.interfaces.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace rest_api_ddd.application
{
    class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;


        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }
        public void Add(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
