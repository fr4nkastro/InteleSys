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
        public class Modelo
        {
            public decimal id { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
        }

        public class MantenimientoFecha
        {
            public Decimal id { get; set; }
            public DateTime Fecha { get; set;}
        }
        public class Maquina
        {
            public Decimal ID { get; set; }
            public String Serie { get; set; }
        }
    }
}
