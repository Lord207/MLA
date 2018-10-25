using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLA.DAL.Common
{


    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate);

        TEntity GetById(Guid id);


        void Create(TEntity item);
        void Remove(TEntity item);
        void Remove(Guid id);
        void Update(TEntity item);
    }


}
