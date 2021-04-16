using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace tap2021_e02.RepositoryPattern
{
    public interface ISampleRepository<TEntity>
    {
        IEnumerable<TEntity> Query();
        void InsertSample(TEntity entity);
        void UpdateSample(TEntity entity);
        void DeleteSample(TEntity entity);


    }

    public interface IUnitOfWork
    {
        void Commit();
    }
}
