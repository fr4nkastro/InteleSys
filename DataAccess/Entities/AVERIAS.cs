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
    
    public partial class AVERIAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AVERIAS()
        {
            this.REGISTRO_AVERIA = new HashSet<REGISTRO_AVERIA>();
        }
    
        public decimal id { get; set; }
        public string descripcion { get; set; }
        public string solucion { get; set; }
        public decimal modelo_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_AVERIA> REGISTRO_AVERIA { get; set; }
        public virtual MODELO MODELO { get; set; }
    }
}
