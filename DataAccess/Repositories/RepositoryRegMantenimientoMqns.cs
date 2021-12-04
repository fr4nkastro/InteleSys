using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;


namespace DataAccess.Repositories
{
    public class RepositoryRegMantenimientoMqns : IGenericRepository<REG_MANTENIMIENTO_MQNs>

    {
        public void Add(REG_MANTENIMIENTO_MQNs entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.REG_MANTENIMIENTO_MQNs.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(REG_MANTENIMIENTO_MQNs entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<REG_MANTENIMIENTO_MQNs> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.REG_MANTENIMIENTO_MQNs.AsNoTracking().ToList<REG_MANTENIMIENTO_MQNs>();
            }
        }

        public void Remove(decimal id)
        {
            using (var context = new InteleSysEntities())
            {
                REG_MANTENIMIENTO_MQNs objRegMantenimientoMqns = context.REG_MANTENIMIENTO_MQNs.Find(id);
                context.REG_MANTENIMIENTO_MQNs.Remove(objRegMantenimientoMqns);
                context.SaveChanges();

            }
        }

    }
}
