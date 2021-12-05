using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class RepositoryMantenimientoFecha : IGenericRepository<MANTENIMIENTO>
    {
        public void Add(MANTENIMIENTO entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.MANTENIMIENTO.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(MANTENIMIENTO entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<MANTENIMIENTO> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.MANTENIMIENTO.AsNoTracking().ToList<MANTENIMIENTO>();
            }
        }

        public void Remove(decimal id)
        {
            using (var context = new InteleSysEntities())
            {
                MANTENIMIENTO objARTICULO = context.MANTENIMIENTO.Find(id);
                context.MANTENIMIENTO.Remove(objARTICULO);
                context.SaveChanges();

            }
        }
    }
}
