using rest_api_ddd.application.dtos;
using System.Collections.Generic;

namespace rest_api_ddd.application.interfaces
{
    public interface IApplicationServiceProduct
    {   /// <summary>
        ///
        /// </summary>
        /// <param name="productDto"></param>
        void Add(ProductDto productDto);

        /// <summary>
        ///
        /// </summary>
        /// <param name="productDto"></param>
        void Update(ProductDto productDto);

        /// <summary>
        ///
        /// </summary>
        /// <param name="productDto"></param>
        void Remove(ProductDto productDto);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductDto> GetAll();

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductDto GetById(int id);
    }
}