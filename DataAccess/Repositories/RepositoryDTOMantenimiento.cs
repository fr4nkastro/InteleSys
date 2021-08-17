using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;


namespace DataAccess.Repositories
{
    public class RepositoryDTOMantenimiento: TableDTO
    {
        public List<MantenimientoFechas> GetMantenimientoFechas(string startDate, string endDate)
        {
            using (var context = new InteleSysEntities())
            {
                var result = context.Database.SqlQuery<MantenimientoFechas>(@"SELECT * FROM MANTENIMIENTO WHERE CONVERT(varchar, fecha, 103) BETWEEN '@startDate'  AND '@endDate'",
                    new SqlParameter("starDate", startDate),
                    new SqlParameter("endDate", endDate)).ToList();

                return result;


            }
        }

        //public List<MantenimientoFechas> GetMantenimientoFechas(DateTime dateStart, DateTime dateEnd)
        //{
            //using (var context = new InteleSysEntities())
            //{
                //var mantenimientos = context.MANTENIMIENTO.Select(mantenimiento => new MantenimientoFechas
                //{
                //    id = mantenimiento.id,
                //    date = mantenimiento.fecha

                //}).Where(s => (DbFunctions.TruncateTime(s.date) >= dateStart && DbFunctions.TruncateTime(s.date) <= dateEnd)).ToList();
                //var result = (from f in context.MANTENIMIENTO where f.fecha >= dateStart && f.fecha <= dateEnd select new MantenimientoFechas { id= f.id, date=f.fecha }).ToList();
                //return result
            //}

        //}
    }
}
