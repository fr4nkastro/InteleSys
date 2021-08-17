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
    public class RepositoryDTOMantenimientoFecha: TableDTO
    {
        public List<TableMantenimientoFecha> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                var result = context.Database.SqlQuery<TableMantenimientoFecha>(@"exec sp_Obtener_MaquinaFecha").ToList();

                return result;

            }

        }

        public List<MantenimientoFecha> GetFechas()
        {
            using (var context = new InteleSysEntities())
            {
                var models = context.MANTENIMIENTO.Select(model => new MantenimientoFecha
                {
                    id = model.id,
                    Fecha = model.fecha,

                }).ToList();


                return models;

            }
        }
        public List<Maquina> GetMaquina()
        {
            using (var context = new InteleSysEntities())
            {
                var models = context.MAQUINA.Select(model => new Maquina
                {
                    ID = model.articulo_id,
                    Serie = model.serialno,

                }).ToList();
                return models;

            }
        }
        public List<TableMaquina> GetAllMaquina()
        {
            using (var context = new InteleSysEntities())
            {
                var result = context.Database.SqlQuery<TableMaquina>(@"select articulo_id as ID ,serialno as Serie from MAQUINA").ToList();

                return result;

            }

        }

        public List<TableMantenimientoFecha> Search(string filter)
        {
            return GetAll().Where<TableMantenimientoFecha>(x => x.Fecha.ToString().Contains(filter)).ToList();
        }

    }
}
