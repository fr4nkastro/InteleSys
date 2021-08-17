using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class TableInventarioPiezas
    {
        public decimal ID { get; set; }
        public string No_Serie{ get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
