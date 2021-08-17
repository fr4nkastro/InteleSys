using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.DTO;
using DataAccess.Entities;


namespace DataAccess.Repositories
{
    public class RepositoryDTOInventarioGeneral : TableDTO
    {
        
        public List<TableInventarioGeneral> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                var result = context.Database.SqlQuery<TableInventarioGeneral>(@"exec sp_inventario_general").ToList();

                return result;


            }

        }


        public List<ModeloMaquinas> GetModeloMaquina()
        {
            using (var context = new InteleSysEntities())
            {
                var models = context.MODELO.Select(model => new ModeloMaquinas
                {
                    id = model.id,
                    nombre = model.nombre,

                }).ToList();


                return models;

            }
        }

        public List<TipoArticulo> GetTipoArtilculo()
        {
            using (var context = new InteleSysEntities())
            {
                var models = context.TIPO_ARTICULO.Select(model => new TipoArticulo
                {
                    id = model.id,
                    nombre = model.nombre,

                }).ToList();


                return models;

            }
        }

        public List<TableInventarioGeneral> Search(string filter)
        {
            return GetAll().Where<TableInventarioGeneral>(x => x.Descripción.Contains(filter)).ToList();
        }
    }
}
