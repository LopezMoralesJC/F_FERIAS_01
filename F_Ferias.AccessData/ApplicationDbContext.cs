
using F_Ferias.Models.Identity;
using F_Ferias.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F_Ferias.AccessData;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser , ApplicationRole , int> {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

      public DbSet<ApplicationUser> ApplicationUser { get; set; }

      public DbSet<abc_directorio> abc_Directorio { get; set; }

      public DbSet<accion_por_modulo> accion_Por_Modulo { get; set; }
      public DbSet<actividad_economica_ferias> actividad_Economica_Feria { get; set; }

      public DbSet<actividades_complementarias> actividades_Complementarias { get; set; }

      public DbSet<aplicativo> Aplicativo { get; set; }

      public DbSet<bitacora_evento> bitacora_Evento  { get; set; }

      public DbSet<C_FUNCIONARIOS_PORTALEMPLEO> C_FUNCIONARIOS_PORTALEMPLEO { get; set; }

      public DbSet<clasificacion> clasificacion { get; set; }

      public DbSet<cp_cepomex_mexico> cp_Cepomex_Mexico  { get; set; }

      public DbSet<entidad> entidades  { get; set; }

      public DbSet<feria_actividad_complementaria> Feria_Actividad_Complementaria { get; set; }

      public DbSet<ferias_empleo_local> Ferias_Empleo_Local { get; set; }

      public DbSet<feria_inversion> Feria_Inversion { get; set; }

      public DbSet<feria_modalidad> Feria_Modalidad { get; set; }

      public DbSet<ferias_nacional> Ferias_Nacional { get; set; }

      public DbSet<feria_tamanio> Feria_Tamanio { get; set; }

      public DbSet<ferias_estatus> Ferias_Estatus { get; set; }

      public DbSet<modulo> Modulo  { get; set; }

      public DbSet<oficina> Oficina { get; set; }

      public DbSet<Persona> Persona { get; set; }

      public DbSet<poblacion_especifica> Poblacion_Especifica { get; set; }

      public DbSet<tipo_evento_ferias> Tipo_Evento_Feria  { get; set; }

      public DbSet<tipo_propietario> Tipo_Propietario  { get; set; }

      public DbSet<tipo_recurso> Tipo_Recurso  { get; set; }

      public DbSet<tipodiscapacidad> TipoDiscapacidad { get; set; }




      // public DbSet<ApplicationRole> ApplicationRole { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
    }
}
