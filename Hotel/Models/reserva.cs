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
    
    public partial class reserva
    {
        public int id { get; set; }
        public int habitacion_id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string agencia_nombre { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaTermino { get; set; }
    
        public virtual habitacion habitacion { get; set; }
    }
}