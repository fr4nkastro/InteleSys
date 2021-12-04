using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Repositories;

namespace Domain.Models
{
    public class ModelObservaciones
    {
        OBSERVACIONES obj;
        RepositorioObservaciones repository;

        public ModelObservaciones()
        {
            obj = new OBSERVACIONES();
            repository = new RepositorioObservaciones();
        }

        public List<OBSERVACIONES> GetAll()
        {
            using (var context = new InteleSysEntities())
            {
                return context.OBSERVACIONES.ToList();

            }
        }

        public void Add(OBSERVACIONES obj)
        {
            repository.Add(obj);

           
        }

        public void Edit(OBSERVACIONES objPieza)
        {
            repository.Add(objPieza);
        }

        public void Remove(decimal id)
        {
            repository.Remove(id);
        }
    }
}
