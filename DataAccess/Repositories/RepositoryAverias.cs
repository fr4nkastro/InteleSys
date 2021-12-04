using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.DTO;

namespace DataAccess.Repositories
{
    public class RepositoryAverias : IGenericRepository<AVERIAS>
    {
        public void Add(AVERIAS entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.AVERIAS.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(AVERIAS entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<AVERIAS> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.AVERIAS.AsNoTracking().ToList<AVERIAS>();
            }
        }

        public void Remove(decimal id)
        {
            using (var context = new InteleSysEntities())
            {
                AVERIAS objAverias = context.AVERIAS.Find(id);
                context.AVERIAS.Remove(objAverias);
                context.SaveChanges();

            }
        }
    }
}
