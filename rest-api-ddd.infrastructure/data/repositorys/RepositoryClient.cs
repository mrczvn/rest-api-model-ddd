using rest_api_ddd.domain.core.interfaces.repositories;
using rest_api_ddd.domain.entitys;

namespace rest_api_ddd.infrastructure.data.repositorys
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        /// <summary>
        ///
        /// </summary>
        /// <param name="sqlContext"></param>
        public RepositoryClient(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}