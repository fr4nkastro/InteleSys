using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
  public  class RepositorioObservaciones: IGenericRepository<OBSERVACIONES>
    {
        public void Add(OBSERVACIONES entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.OBSERVACIONES.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(OBSERVACIONES entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<OBSERVACIONES> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.OBSERVACIONES.AsNoTracking().ToList<OBSERVACIONES>();
            }
        }

        public void Remove(decimal id)
        {
            using (var context = new InteleSysEntities())
            {
                OBSERVACIONES obj = context.OBSERVACIONES.Find(id);
                context.OBSERVACIONES.Remove(obj);
                context.SaveChanges();

            }
        }


    }
}
