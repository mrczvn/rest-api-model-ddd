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

        /// <summary>
        ///
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}