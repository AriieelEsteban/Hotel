//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hoteles.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public habitacion()
        {
            this.reserva = new HashSet<reserva>();
        }
    
        public int id { get; set; }
        public string codigo { get; set; }
        public byte clase { get; set; }
        public int hotel_id { get; set; }
        public int precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reserva> reserva { get; set; }
        public virtual hotel hotel { get; set; }
    }
}