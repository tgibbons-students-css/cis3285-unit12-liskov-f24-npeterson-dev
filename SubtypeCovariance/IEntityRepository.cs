using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public interface IEntityRepository<TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
    }
}
