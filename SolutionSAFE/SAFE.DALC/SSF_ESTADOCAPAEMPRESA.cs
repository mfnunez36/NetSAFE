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
    
    public partial class SSF_ESTADOCAPAEMPRESA
    {
        public SSF_ESTADOCAPAEMPRESA()
        {
            this.SSF_CAPACITACIONEMPRESA = new HashSet<SSF_CAPACITACIONEMPRESA>();
        }
    
        public decimal ID { get; set; }
        public Nullable<System.DateTime> FECH_CREACION { get; set; }
        public Nullable<short> ESTADO { get; set; }
        public string ESTADOCAPAEMP { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<SSF_CAPACITACIONEMPRESA> SSF_CAPACITACIONEMPRESA { get; set; }
    }
}
