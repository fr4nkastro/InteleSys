using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.DTO
{
    public class TableInventarioGeneral
    {

        public decimal ID { get; set; }
        //[DisplayName ("No.Serie")]
        //[Description("Codigo único para el modelo de artículo")]

        public string No_Serie { get; set; }
        public string Descripción { get; set; }
        public string Modelo { get; set; }

        public decimal Cantidad { get; set; }

        //[DisplayName("Tipo Articulo")]
        public string Tipo_Articulo { get; set; }

        
        
        //private decimal precio;|
        //[DisplayName("Precio Costo")]
        //[DataType(DataType.Currency)]
        
        public decimal Precio { get; set; }
        //public decimal Precio { get { return decimal.Round(precio, 2, MidpointRounding.AwayFromZero); } set { precio = decimal.Round(value, 2, MidpointRounding.AwayFromZero); } }
    }

}
