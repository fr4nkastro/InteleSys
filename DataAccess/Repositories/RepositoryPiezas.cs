using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public  class RepositoryPiezas : IGenericRepository<PIEZAS>
    {
        public void Add(PIEZAS entity)
        {
            using (var context= new InteleSysEntities())
            {
                context.PIEZAS.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(PIEZAS entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<PIEZAS> GetAll()
        {
            using(var context= new InteleSysEntities())
            {
                return context.PIEZAS.AsNoTracking().ToList<PIEZAS>();
            }
        }

        public void Remove(int id)
        {
            using(var context= new InteleSysEntities())
            {
                PIEZAS objPiezas = context.PIEZAS.Find(id);
                context.PIEZAS.Remove(objPiezas);
                context.SaveChanges();

            }
        }
    }
}
