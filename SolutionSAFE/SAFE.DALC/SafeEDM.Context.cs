﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SafeEntities : DbContext
    {
        public SafeEntities()
            : base("name=SafeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SSF_ADJUNTO> SSF_ADJUNTO { get; set; }
        public DbSet<SSF_ALUMNO> SSF_ALUMNO { get; set; }
        public DbSet<SSF_ALUMNOCAPAEMPRESA> SSF_ALUMNOCAPAEMPRESA { get; set; }
        public DbSet<SSF_ASISTENCIA> SSF_ASISTENCIA { get; set; }
        public DbSet<SSF_ATENCIONMEDICA> SSF_ATENCIONMEDICA { get; set; }
        public DbSet<SSF_CAPACITACION> SSF_CAPACITACION { get; set; }
        public DbSet<SSF_CAPACITACIONDIA> SSF_CAPACITACIONDIA { get; set; }
        public DbSet<SSF_CAPACITACIONEMPRESA> SSF_CAPACITACIONEMPRESA { get; set; }
        public DbSet<SSF_CAPACITACIONTIPO> SSF_CAPACITACIONTIPO { get; set; }
        public DbSet<SSF_CENTROMEDICO> SSF_CENTROMEDICO { get; set; }
        public DbSet<SSF_CERTIFICADO> SSF_CERTIFICADO { get; set; }
        public DbSet<SSF_EMPRESA> SSF_EMPRESA { get; set; }
        public DbSet<SSF_ESTADOCAPAEMPRESA> SSF_ESTADOCAPAEMPRESA { get; set; }
        public DbSet<SSF_EVALUACION> SSF_EVALUACION { get; set; }
        public DbSet<SSF_EVALUACIONESTADO> SSF_EVALUACIONESTADO { get; set; }
        public DbSet<SSF_EVALUACIONPARAMETRO> SSF_EVALUACIONPARAMETRO { get; set; }
        public DbSet<SSF_EVALUACIONTIPO> SSF_EVALUACIONTIPO { get; set; }
        public DbSet<SSF_EXAMEN> SSF_EXAMEN { get; set; }
        public DbSet<SSF_EXAMENTIPO> SSF_EXAMENTIPO { get; set; }
        public DbSet<SSF_FICHAMEDICA> SSF_FICHAMEDICA { get; set; }
        public DbSet<SSF_FICHAMEDICAATENCION> SSF_FICHAMEDICAATENCION { get; set; }
        public DbSet<SSF_MEDICO> SSF_MEDICO { get; set; }
        public DbSet<SSF_MEDICOESPECIALIDAD> SSF_MEDICOESPECIALIDAD { get; set; }
        public DbSet<SSF_MENU> SSF_MENU { get; set; }
        public DbSet<SSF_PARAMETRO> SSF_PARAMETRO { get; set; }
        public DbSet<SSF_PERFIL> SSF_PERFIL { get; set; }
        public DbSet<SSF_PERFILVISTA> SSF_PERFILVISTA { get; set; }
        public DbSet<SSF_PERSONA> SSF_PERSONA { get; set; }
        public DbSet<SSF_USUARIO> SSF_USUARIO { get; set; }
        public DbSet<SSF_VISTA> SSF_VISTA { get; set; }
    }
}