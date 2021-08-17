using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public abstract class TableDTO
    {
        public class ModeloMaquinas
        {
            public decimal id { get; set; }
            public string nombre { get; set; }
        }

        public class TipoArticulo
        {
            public decimal id { get; set; }
            public string nombre { get; set; }

        }

        public class MantenimientoMaquinas
        {
            public decimal id { get; set; }
            public string serialNO { get; set; }
        }

        public  class MantenimientoAverias
        {   
            public decimal id { get; set; }
            public string nombre { get; set; }

        }

        public class MantenimientoObservaciones
        {
            public decimal id { get; set; }
            public string nombre { get; set; }
        }

        public class MantenimientoActividades
        {
            public decimal id
            {
                get; set;
            }
            public string nombre
            {
                get; set;
            }
        }

        public class MantenimientoFechas
        {
            public decimal id { get; set; }
            public DateTime date { get; set; }
        }
    }
}
