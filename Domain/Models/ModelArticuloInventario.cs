using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class ModelArticuloInventario
    {
        ARTICULO_INVENTARIO objArticuloInventario;
        RepositoryArticuloInventario repository;

        public ModelArticuloInventario()
        {
            objArticuloInventario = new ARTICULO_INVENTARIO();
            repository = new RepositoryArticuloInventario();
        }

        public List<ARTICULO_INVENTARIO> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.ARTICULO_INVENTARIO.ToList();

            }
        }

        public void Add(ARTICULO_INVENTARIO objArticuloInventario)
        {
            repository.Add(objArticuloInventario);
        }

        public void Edit(ARTICULO_INVENTARIO objPieza)
        {
            repository.Edit(objPieza);
        }

    }
}
