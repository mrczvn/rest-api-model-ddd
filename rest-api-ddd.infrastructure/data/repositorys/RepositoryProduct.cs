using rest_api_ddd.domain.core.interfaces.repositories;
using rest_api_ddd.domain.entitys;

namespace rest_api_ddd.infrastructure.data.repositorys
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        /// <summary>
        ///
        /// </summary>
        /// <param name="sqlContext"></param>
        public RepositoryProduct(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}