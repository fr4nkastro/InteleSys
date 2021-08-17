using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTO
{
    public class TablaAveriasModelo
    {
        public decimal ID { get; set; }
        public string DescripcionAveria { get; set; }
        public string Solucion { get; set; }
        public string Modelo { get; set; }
        public string DescripcionModelo { get; set; }
    }
}
