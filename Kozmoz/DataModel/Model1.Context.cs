﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kosmozbusEntities : DbContext
    {
        public kosmozbusEntities()
            : base("name=kosmozbusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<actualizacion> actualizacions { get; set; }
        public DbSet<departamento> departamentoes { get; set; }
        public DbSet<empresaservicio> empresaservicios { get; set; }
        public DbSet<log> logs { get; set; }
        public DbSet<rol> rols { get; set; }
        public DbSet<trabajador> trabajadors { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<ciudad> ciudads { get; set; }
        public DbSet<colonia> colonias { get; set; }
        public DbSet<cp> cps { get; set; }
        public DbSet<municipio> municipios { get; set; }
        public DbSet<patio> patios { get; set; }
    }
}
