//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class trabajador
    {
        public trabajador()
        {
            this.usuarios = new HashSet<usuario>();
        }
    
        public int id { get; set; }
        public Nullable<int> iddepartamentofk { get; set; }
        public string nombre { get; set; }
        public string edad { get; set; }
        public string genero { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string numero_empleado { get; set; }
        public string cargo { get; set; }
        public string imagen { get; set; }
        public Nullable<System.DateTime> fecha_creaccion { get; set; }
    
        public virtual departamento departamento { get; set; }
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
