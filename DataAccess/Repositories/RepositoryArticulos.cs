using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;


namespace DataAccess.Repositories
{
    public class RepositoryArticulos : IGenericRepository<ARTICULO>
    {
        public void Add(ARTICULO entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.ARTICULO.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(ARTICULO entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<ARTICULO> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.ARTICULO.AsNoTracking().ToList<ARTICULO>();
            }
        }

        public void Remove(decimal id)
        {
            using (var context = new InteleSysEntities())
            {
                ARTICULO objARTICULO = context.ARTICULO.Find(id);
                context.ARTICULO.Remove(objARTICULO);
                context.SaveChanges();

            }
        }
    }
}
