using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class ModelTareas
    {
        TAREAS obj;
        RepositoryTareas repository;

        public ModelTareas()
        {
            obj = new TAREAS();
            repository = new RepositoryTareas();
        }

        public List<TAREAS> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.TAREAS.ToList();

            }
        }

        public void Add(TAREAS obj)
        {
            repository.Add(obj);


        }

        public void Edit(TAREAS objPieza)
        {
            repository.Add(objPieza);
        }

        public void Remove(decimal id)
        {
            repository.Remove(id);
        }
    }
}
