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
    
    public partial class empresaservicio
    {
        public empresaservicio()
        {
            this.departamentoes = new HashSet<departamento>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string nombre_corto { get; set; }
        public string cabezera { get; set; }
        public string imagen { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public int cp { get; set; }
        public string municipio { get; set; }
        public string ciudad { get; set; }
        public string encargado1 { get; set; }
        public string encargado2 { get; set; }
        public string correo1 { get; set; }
        public string coreo2 { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
    
        public virtual ICollection<departamento> departamentoes { get; set; }
    }
}
