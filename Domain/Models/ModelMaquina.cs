using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class ModelMaquina
    {
        MAQUINA obj;
        RepositoryMaquinas repository;

        public ModelMaquina()
        {
            obj = new MAQUINA();
            repository = new RepositoryMaquinas();
        }

        public List<MAQUINA> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.MAQUINA.ToList();

            }
        }

        public void Add(MAQUINA obj)
        {
            repository.Add(obj);
            

        }

        public void Edit(MAQUINA objPieza)
        {
            repository.Add(objPieza);
        }

        public void Remove(decimal id)
        {
            repository.Remove(id);
        }
    }
}
