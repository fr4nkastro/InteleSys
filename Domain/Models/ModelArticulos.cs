using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class ModelArticulos
    {
        ARTICULO objArticulo;
        RepositoryArticulos repository;

        public ModelArticulos()
        {
            objArticulo = new ARTICULO();
            repository = new RepositoryArticulos();
        }

        public List<ARTICULO> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.ARTICULO.ToList();

            }
        }

        public void Add(ARTICULO objArticulo)
        {
            repository.Add(objArticulo);
        }

        public void Edit(ARTICULO objPieza)
        {
            repository.Add(objPieza);
        }
    }
}
