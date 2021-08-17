using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess.Contracts;
using System.Collections;

namespace Domain.Models
{
    public class ModelDTOMantenimiento: TableDTO
    {
        RepositoryDTOMantenimiento objDTOMantenimiento;
        List<MantenimientoFechas> lstmantenimientoFechas;
        public ModelDTOMantenimiento()
        {
            objDTOMantenimiento = new RepositoryDTOMantenimiento();
            lstmantenimientoFechas = new List<MantenimientoFechas>();
        }

        //public object GetAverias(string starDate, string endDate)
        //{
        //    return objDTOMantenimiento.GetAverias(starDate, endDate).ToList();
        //}

        public object GetMantenimientoFechas(string dateStart, string dateEnd)
        {
            lstmantenimientoFechas= objDTOMantenimiento.GetMantenimientoFechas(dateStart, dateEnd);
            ArrayList arrayList = new ArrayList();
            foreach (var item in lstmantenimientoFechas)
            {
                arrayList.Add(item.date.ToString());
            }
            return arrayList;
        }
    }
}
