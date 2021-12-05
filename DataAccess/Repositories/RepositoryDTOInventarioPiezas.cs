using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using DataAccess.DTO;
using DataAccess.Contracts;

namespace DataAccess.Repositories
{
    public class RepositoryDTOInventarioPiezas: TableDTO
    {
        

        public RepositoryDTOInventarioPiezas()
        {


        }


        public IEnumerable<TableInventarioPiezas> GetAll()
        {   
            using (var context = new InteleSysEntities())
            {
                var result = context.Database.SqlQuery<TableInventarioPiezas>(@"exec sp_inventario_piezas").ToList();

                return result;


            }

        }

        public IEnumerable<ModeloMaquinas> GetModels()
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
    }
}

