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
    
    public partial class REGISTRO_TECNICOS
    {
        public decimal reg_id { get; set; }
        public decimal tecnico_id { get; set; }
        public decimal mantenimiento_id { get; set; }
    
        public virtual MANTENIMIENTO MANTENIMIENTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
