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
    public class RepositoryArticuloInventario:IGenericRepository<ARTICULO_INVENTARIO>
    {
        public void Add(ARTICULO_INVENTARIO entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.ARTICULO_INVENTARIO.Add(entity);
                context.SaveChanges();
            }
        }

        public void Edit(ARTICULO_INVENTARIO entity)
        {
            using (var context = new InteleSysEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public IEnumerable<ARTICULO_INVENTARIO> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.ARTICULO_INVENTARIO.AsNoTracking().ToList<ARTICULO_INVENTARIO>();
            }
        }

        public void Remove(int id)
        {
            using (var context = new InteleSysEntities())
            {
                ARTICULO_INVENTARIO objARTICULO_INVENTARIO = context.ARTICULO_INVENTARIO.Find(id);
                context.ARTICULO_INVENTARIO.Remove(objARTICULO_INVENTARIO);
                context.SaveChanges();

            }
        }
    }
}
