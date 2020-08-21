using rest_api_ddd.application.dtos;
using rest_api_ddd.domain.entitys;
using System.Collections.Generic;

namespace rest_api_ddd.infrastructure.cross_cutting.interfaces
{
    public interface IMapperProduct
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="productDto"></param>
        /// <returns></returns>
        Product MapperDtoToEntity(ProductDto productDto);

        /// <summary>
        ///
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products);

        /// <summary>
        ///
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        ProductDto MapperEntityToDto(Product product);
    }
}