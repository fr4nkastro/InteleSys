using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        void Add(Entity entity);
        void Edit(Entity entity);
        void Remove(decimal id);
        IEnumerable<Entity> GetAll();
    }
}
