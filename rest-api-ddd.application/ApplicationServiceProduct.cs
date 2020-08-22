using rest_api_ddd.application.dtos;
using rest_api_ddd.application.interfaces;
using rest_api_ddd.application.interfaces.mappers;
using rest_api_ddd.domain.core.interfaces.services;
using System;
using System.Collections.Generic;

namespace rest_api_ddd.application
{
    internal class ApplicationServiceProduct : IApplicationServiceProduct
    {
        // fabio.pea@gmail.com
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="productDto"></param>
        public void Add(ProductDto productDto)
        {
            var product = mapperProduct.MapperDtoToEntity(productDto);
            serviceProduct.Add(product);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductDto> GetAll()
        {
            var products = serviceProduct.GetAll();
            return mapperProduct.MapperListProductsDto(products)
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