using rest_api_ddd.application.dtos;
using rest_api_ddd.domain.entitys;
using rest_api_ddd.infrastructure.cross_cutting.interfaces;
using System;
using System.Collections.Generic;

namespace rest_api_ddd.infrastructure.cross_cutting.mapper
{
    public class MapperProduct : IMapperProduct
    {
        private IEnumerable<ProductDto> productDtos = new List<ProductDto>();

        /// <summary>
        ///
        /// </summary>
        /// <param name="productDto"></param>
        /// <returns></returns>
        public Product MapperDtoEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Value = productDto.Value
            };

            return product;
        }

        public Product MapperEntityToDto(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}