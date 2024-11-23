using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public abstract class EntityRepository<TEntity> : IEntityRepository<TEntity>
            where TEntity : Entity
    {
        protected readonly Dictionary<Guid, TEntity> _entities = new Dictionary<Guid, TEntity>();

        public TEntity GetByID(Guid id)
        {
            _entities.TryGetValue(id, out var entity);
            return entity;
        }

        public void Add(TEntity entity)
        {
            if (!_entities.ContainsKey(entity.ID))
            {
                _entities[entity.ID] = entity;
            }
        }

        public void Update(TEntity entity)
        {
            if (_entities.ContainsKey(entity.ID))
            {
                _entities[entity.ID] = entity;
            }
        }

        public void Delete(Guid id)
        {
            _entities.Remove(id);
        }
    }
}
