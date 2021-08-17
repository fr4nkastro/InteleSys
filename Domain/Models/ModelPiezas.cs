using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class ModelPiezas
    {
        PIEZAS objPiezas;
        RepositoryPiezas repository;

        public ModelPiezas()
        {
            objPiezas = new PIEZAS();
            repository = new RepositoryPiezas();
        }

        public List<PIEZAS> GetAll()
        {
            using (var context= new InteleSysEntities())
            {
                return context.PIEZAS.ToList();

            }
        }

        public void Add(PIEZAS objPieza)
        {
            repository.Add(objPieza);
        }

        public void Edit(PIEZAS objPieza)
        {

        }
    }
}
