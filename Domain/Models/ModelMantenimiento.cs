using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess.Entities;
using System.Collections;

namespace Domain.Models
{
    public class ModelMantenimiento
    {
        RepositoryMantenimiento repository;
        public List<MANTENIMIENTO> lstMantenimiento { get; set; }

        public ModelMantenimiento()
        {
            repository = new RepositoryMantenimiento();
        }
        
        public IEnumerable<MANTENIMIENTO> getAll()
        {
           return repository.GetAll();    
        }
        public void Add(MANTENIMIENTO mantenimiento)
        {
            repository.Add(mantenimiento);
        }

        public List<MANTENIMIENTO> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return repository.GetAll().ToList().FindAll(m => m.fecha <= endDate && m.fecha >= startDate);
        }

        public ArrayList listFechasMantenimiento(DateTime startDate, DateTime endDate)
        {
            lstMantenimiento = GetByDateRange(startDate, endDate);

            ArrayList arrayList = new ArrayList();
            foreach (var item in lstMantenimiento)
            {
                arrayList.Add(item.fecha.ToShortDateString());

            }
            return arrayList;
        }

        public void Remove(Decimal MantenimientoId)
        {
            repository.Remove(MantenimientoId);
        }

    }
}
