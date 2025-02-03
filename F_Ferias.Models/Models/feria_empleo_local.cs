using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models;
    public class ferias_empleo_local {
       public ferias_empleo_local() {
           ferias_locales_banners = new HashSet<ferias_locales_banners>();
       }








       [Key]
       public int id { get; set; }
       public int estatus { get; set; }  // FK Estatus feria

      [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime created_at { get; set; }

      [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime updated_at { get; set; }

      [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime deleted_at { get; set; }

     

       // SECCION 1 ----------------------------------------------------------------------------
       public string titulo { get; set; }
       public int clasificacion { get; set; }   // FK  1 "Feria de empleo"  2 "Reclutamiento"
       public int modalidad { get; set; }         // FK Modalidad Presencial 1 o Virtual 2
       public bool publicacion { get; set; }

       public int? actividad_economica { get; set; } // FK actividad economica
       public string otra_actividad_economica { get; set; }

       public int tipo_evento { get; set; } // FK
       public int? poblacion_especifica { get; set; }  // FK
       public string otros_tipo_poblacion { get; set; }

       public int? justificacion_feria { get; set; } // Fk Justificacion
       public string otros_tipo_justificacion { get; set; } // otra justificacion


       public int asiste_empresas { get; set; }
       public int asiste_oferta_empleo { get; set; }
       public int asiste_solicitan_empleo { get; set; }
       public int asiste_solicitan_colocado { get; set; }

       public bool es_usne { get; set; }
       public bool es_osne { get; set; }




   
        // 1	"Activo"
        // 2	"Publicado"
        // 3	"Concluido"
        // 4	"Rechazado por USNE"
        // 5	"Validado por USNE"
        // 6	"Reactivado"
        // 7	"Validado por OSNE"
        // 8	"Rechazado por OSNE"
        // 9	"Cancelado"
      public bool es_virtual { get; set; }
      public int user_create { get; set; }       // FK USUARIO
      public int? user_upddel { get; set; }   // FK USUARIO

      public int id_feriatamanio { get; set; } // FK  Grande 1, Mediana 2
      public bool es_nacional { get; set; }
      public int? id_feria_nacional { get; set; } // FK

      public int id_entidad { get; set; }        // FK
      public int id_unidadresponsable { get; set; } // FK



      [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime fecha_ini { get; set; }
      
      [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime fecha_fin { get; set; }
      [System.ComponentModel.DataAnnotations.Display(Name = "Hora Fin*:")]
      [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
      [DataType(DataType.Time)]
      public DateTime hora_inicio { get; set; }
      
      [System.ComponentModel.DataAnnotations.Display(Name = "Hora Fin*:")]
      [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
      [DataType(DataType.Time)]
      public DateTime hora_fin { get; set; }




      // SECCION 2 ----------------------------------------------------------------------------







      public bool misma_cede { get; set; }   // Misma sede feria del empleo portal www.


      public string  plataforma { get; set; }
      public string  plataforma_evento { get; set; }
      public string  plataforma_contrasena { get; set; }
      public string  plataforma_url { get; set; }



      public string cp_direccion { get; set; }
      public int? id_entidad_federativa_feria_local { get; set; }
      public string municipio { get; set; }
      public string colonia { get; set; }
      public string vialidad { get; set; }
      public string sede_evento { get; set; }
      public string calle { get; set; }
      public int numeroExt { get; set; }
      public int numeroInt { get; set; }
      public string referencias_direccion { get; set; }











      // SECCION 3 ----------------------------------------------------------------------------
    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_publicacion { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_pre_registro_empresa { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_pre_registro_buscador { get; set; }
    
    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_max_asistencia { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_max_participantes { get; set; }





   // SECCION 4----------------------------------------------------------------------------



    
    public bool? talleres_para_personas_buscadoras_empleo { get; set; } // FK
    public string  otra_tipo_recurso { get; set; }
    public int? id_actividad_complementaria { get; set; } // FK
    public bool? actividad_complementaria { get; set; } // FK
    public string otra_actividad { get; set; }
    public int? id_feria_inversion { get; set; } // FK
    public int? id_tipo_recurso { get; set; } // FK

    





   // No Mapped ------------------------------------------------------------------------------------------
   
    [NotMapped]
    public string file__name{ get; set; }

    [NotMapped]
    public byte[] feria_logo_banner { get; set; } 

    // No Mapped ------------------------------------------------------------------------------------------



    // CLAVES FORANEAS  ---------------------------------------------------------------------------------

    [ForeignKey("clasificacion")]
    public virtual clasificacion id_clasificacion_asociado { get; set; }
    [ForeignKey("modalidad")]
    public virtual feria_modalidad id_modalidad_asociado { get; set; }
    [ForeignKey("actividad_economica")]
    public virtual actividad_economica_ferias id_actividad_economica_asociado { get; set; }
    [ForeignKey("poblacion_especifica")]
    public virtual poblacion_especifica id_poblacion_especifica_asociado { get; set; }

    [ForeignKey("tipo_evento")]
    public virtual tipo_evento_ferias id_tipo_evento_asociado { get; set; }

    [ForeignKey("justificacion_feria")]
    public virtual justificaciones justificacion_feria_local { get; set; }
 
  

    [ForeignKey("id_actividad_complementaria")]
    public virtual actividades_complementarias  id_actividad_complementaria_asociado_FK { get; set; }

    [ForeignKey("estatus")]
    public virtual ferias_estatus estatus_feria_asociado { get; set; }

    [ForeignKey("id_feriatamanio")]
    public virtual feria_tamanio id_feriatamanio_asociado { get; set; }

    [ForeignKey("user_create")]
    public virtual ApplicationUser usuario_Inserto { get; set; }

    [ForeignKey("user_upddel")]
    public virtual ApplicationUser usuario_Actualizo { get; set; }

    [ForeignKey("id_feria_nacional")]
    public virtual ferias_nacional id_feria_nacional_asociado { get; set; }

    [ForeignKey("id_entidad")]
    public virtual entidad id_entidad_asociado { get; set; }

    [ForeignKey("id_entidad_federativa_feria_local")]
    public virtual entidad id_entidad_feria_presencial_ubicacion { get; set; }

    [ForeignKey("id_unidadresponsable")]
     public virtual abc_directorio id_unidad_responsable_asociada_FK { get; set; }


    [ForeignKey("id_tipo_recurso")]  // Clave foranea  # 1 En especie  | # 2  Federal # 3 Estatal   # 4 Mixta
    public virtual tipo_recurso id_tipo_recurso_asociado { get; set; }

    [ForeignKey("id_feria_inversion")] // Tabla donde se guardan las distribuciones de FERIA DE INVERION
     public virtual feria_inversion Feria_Inversion_FK { get; set; }

     public virtual  ICollection<ferias_locales_banners> ferias_locales_banners { get; set; }  
  

    }