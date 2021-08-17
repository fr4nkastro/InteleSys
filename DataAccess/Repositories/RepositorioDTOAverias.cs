using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class RepositorioDTOAverias: TableDTO
    {
        public List<TablaAveriasModelo> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                var result = context.Database.SqlQuery<TablaAveriasModelo>(@"exec sp_Vista_Averias").ToList();

                return result;


            }

        }

        public List<Modelo> GetModelo()
        {
            using (var context = new InteleSysEntities())
            {
                var models = context.MODELO.Select(model => new Modelo
                {
                    id = model.id,
                    Nombre = model.nombre,
                    Descripcion=model.descripcion,

                }).ToList();


                return models;

            }
        }

        public List<TablaAveriasModelo> Search(string filter)
        {
            return GetAll().Where<TablaAveriasModelo>(x => x.Modelo.Contains(filter) || x.DescripcionAveria.Contains(filter)).ToList();
        }
        public List<TablaAveriasModelo> Search2(string filter)
        {
            return GetAll().Where<TablaAveriasModelo>(x => x.Modelo.Contains(filter)).ToList();
        }

    }
}
