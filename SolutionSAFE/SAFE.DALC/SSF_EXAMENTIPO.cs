//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAFE.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SSF_EXAMENTIPO
    {
        public SSF_EXAMENTIPO()
        {
            this.SSF_EXAMEN = new HashSet<SSF_EXAMEN>();
        }
    
        public decimal ID { get; set; }
        public Nullable<System.DateTime> FECH_CREACION { get; set; }
        public Nullable<short> ESTADO { get; set; }
        public string TIPO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<SSF_EXAMEN> SSF_EXAMEN { get; set; }
    }
}
