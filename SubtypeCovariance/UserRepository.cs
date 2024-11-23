using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        private readonly Dictionary<Guid, User> _users = new Dictionary<Guid, User>();

        public User GetByID(Guid id)
        {
            _users.TryGetValue(id, out var user);
            return user;
        }

        public void Add(User entity)
        {
            if (!_users.ContainsKey(entity.ID))
            {
                _users[entity.ID] = entity;
            }
        }

        public void Update(User entity)
        {
            if (_users.ContainsKey(entity.ID))
            {
                _users[entity.ID] = entity;
            }
        }

        public void Delete(Guid id)
        {
            _users.Remove(id);
        }
    }
}
