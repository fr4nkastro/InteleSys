using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;


namespace DataAccess.Repositories
{
    public class RepositoryMaquinas : IGenericRepository<MAQUINA>
    {
        public void Add(MAQUINA entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.MAQUINA.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(MAQUINA entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<MAQUINA> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.MAQUINA.AsNoTracking().ToList<MAQUINA>();
            }
        }

        public void Remove(int id)
        {
            using (var context = new InteleSysEntities())
            {
                MAQUINA objMaquina = context.MAQUINA.Find(id);
                context.MAQUINA.Remove(objMaquina);
                context.SaveChanges();

            }
        }
    }
}
