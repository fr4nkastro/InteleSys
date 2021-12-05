using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;


namespace DataAccess.Repositories
{
    public class RepositoryTareas : IGenericRepository<TAREAS>

    {
        public void Add(TAREAS entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.TAREAS.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(TAREAS entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<TAREAS> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.TAREAS.AsNoTracking().ToList<TAREAS>();
            }
        }

        public void Remove(decimal id)
        {
            using (var context = new InteleSysEntities())
            {
                TAREAS objRegMantenimientoMqns = context.TAREAS.Find(id);
                context.TAREAS.Remove(objRegMantenimientoMqns);
                context.SaveChanges();

            }
        }

    }
}
