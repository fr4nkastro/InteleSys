//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTICULO_INVENTARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULO_INVENTARIO()
        {
            this.REGISTRO_INVENTARIO = new HashSet<REGISTRO_INVENTARIO>();
        }
    
        public Nullable<decimal> cantidad { get; set; }
        public decimal articulo_id { get; set; }
        public decimal inventario_id { get; set; }
    
        public virtual ARTICULO ARTICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_INVENTARIO> REGISTRO_INVENTARIO { get; set; }
        public virtual INVENTARIO INVENTARIO { get; set; }
    }
}