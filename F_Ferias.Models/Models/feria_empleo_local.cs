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


        // SECCION 1 ----------------------------------------------------------------------------

    [Key]
    public int id { get; set; }

    public int? estatus { get; set; }  // FK Estatus feria

    [Display(Name = "Clasificación *")]
    public int? clasificacion { get; set; }   // FK  1 "Feria de empleo"  2 "Reclutamiento"

    [Display(Name = "Modalidad (Ambiente) * ")]
    public int? modalidad { get; set; }         // FK Modalidad Presencial 1 o Virtual 2

    [Display(Name = "Publicación")]
    public bool publicacion { get; set; }

    [Display(Name = "Tamaño de feria")]
    public int? id_feriatamanio { get; set; } // FK  Grande 1, Mediana 2

    [Display(Name = "Sector/Actividad Económica *")]
    public int? actividad_economica { get; set; } // FK actividad economica

    [Display(Name = "Otro tipo, ¿Cuál?  *")]
    [StringLength(50, ErrorMessage = "50 caracteres mínimos")]
    public string otra_actividad_economica { get; set; }












    [Display(Name = "Tipo de evento (Población) *")]
    public int tipo_evento { get; set; } // FK

    [Display(Name = "Población específica * ")]

    public int poblacion_especifica { get; set; } = 10; // FK

    [Display(Name = "Otro tipo de población, ¿Cuál? * ")]

    public string otros_tipo_poblacion { get; set; }







    [Display(Name = "Justificación *")]
    public int? justificacion_feria { get; set; } // Fk Justificacion

    [Display(Name = "Otra justificación, ¿Cual? *")]
    public string otros_tipo_justificacion { get; set; } // otra justificacion











    [Range(1, 9999, ErrorMessage = "Ingresa un valor válido")]
    [Display(Name = "De empresas *")]
    public int asiste_empresas { get; set; }
    [Display(Name = "Ofertas de empleo *")]
    [Range(1, 9999, ErrorMessage = "Ingresa un valor válido")]
    public int asiste_oferta_empleo { get; set; }
    [Display(Name = "Personas BT asistentes *")]
    [Range(1, 9999, ErrorMessage = "Ingresa un valor válido")]
    public int asiste_solicitan_empleo { get; set; }
    [Display(Name = "Personas BT colocadas *")]
    [Range(1, 9999, ErrorMessage = "Ingresa un valor válido")]
    public int asiste_solicitan_colocado { get; set; }


















    public bool? es_virtual { get; set; }
    public int? user_create { get; set; }       // FK USUARIO
    public int? user_upddel { get; set; }   // FK USUARIO




    [Display(Name = "Nombre del evento *")]
    [StringLength(50, ErrorMessage = "50 caracteres mínimos")]
    public string titulo { get; set; }

    [Display(Name = "Entidad federativa *")]
    public int? id_entidad { get; set; }        // FK

    [Display(Name = "Unidad Responsable *")]
    public int? id_unidadresponsable { get; set; } // FK


    [Display(Name = "Unidad responsable *")]
    public bool? es_usne { get; set; } = false;
    [Display(Name = "Unidad responsable *")]
    public bool? es_osne { get; set; } = false;

    [Display(Name = "¿Participa en la feria nacional? *")]
    public bool? es_nacional { get; set; } = false;

    [Display(Name = "Ferias nacionales *")]
    public int? id_feria_nacional { get; set; } // FK

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha inicio del evento *")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_ini { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha fin del evento *")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]


    public DateTime fecha_fin { get; set; }
    [System.ComponentModel.DataAnnotations.Display(Name = "Horario de atención (De las) *")]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Time)]
    public DateTime hora_inicio { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "A las *")]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Time)]
    public DateTime hora_fin { get; set; }


    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepción*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime created_at { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepción*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime updated_at { get; set; }

    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepción*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime deleted_at { get; set; }




    // SECCION 2 ----------------------------------------------------------------------------






    // [Display(Name = "¿ Se llevará a cabo en la misma unidad (OSNE responsable) *")]
    public bool? misma_cede { get; set; }   // Misma sede feria del empleo portal www.


    // [Display(Name = "¿El evento virtual se llevará a cabo en el Portal del Empleo? *")]
     public bool? evento_virtual_portal_empleo { get; set; }   // Misma sede feria del empleo portal www.

    public string plataforma { get; set; }
    public string plataforma_evento { get; set; }
    public string plataforma_contrasena { get; set; }
    public string plataforma_url { get; set; }



    public string cp_direccion { get; set; }
    public int id_entidad_federativa_feria_local { get; set; }
    public string municipio { get; set; }
    public string colonia { get; set; }
    public string vialidad { get; set; }
    public string sede_evento { get; set; }
    public string calle { get; set; }
    public int? numeroExt { get; set; }
    public int? numeroInt { get; set; }
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

    public bool? actividad_complementaria { get; set; } // FK

    public string otra_actividad { get; set; }








    // Seccion 4    --------------------------------------------------------------------------------------------------------

 
    public int id_tipo_recurso { get; set; }




    [StringLength(50)]
    public string observacion_recurso_estatal { get; set; } = "Distribución completamente estatal";


    [StringLength(50)]
    public string observacion_promocion_estatal { get; set; }


    public float cantidad_promocion_est { get; set; }




    public string observacion_acondicionamiento_est { get; set; }


    public float cantidad_acondicionamiento_est { get; set; }



    public string observacion_infraestructura_computo_est { get; set; }


    public float cantidad_infraestructura_computo_est { get; set; }


    public string observacion_servicios_videoconferencias_est { get; set; }



    public float cantidad_servicios_videoconferencias_est { get; set; }


    public float cantidad_total_est { get; set; }




    // -------------------------------------------------------------------------------------------

    public string observacion_recurso_federal { get; set; } = "Distribución completamente federal";



    public string observacion_promocion_federal { get; set; }

    public float cantidad_promocion_federal { get; set; }

    public string observacion_acondicionamiento_federal { get; set; }


    public float cantidad_acondicionamiento_federal { get; set; }


    public string observacion_infraestructura_computo_federal { get; set; }



    public float cantidad_infraestructura_computo_federal { get; set; }

  
    public string observacion_alquiler_federal { get; set; }

   

    public float cantidad_alquiler_federal { get; set; }

    public string observacion_servicios_videoconferencias_federal { get; set; }


    public float cantidad_servicios_videoconferencias_federal { get; set; }

    public float cantidad_total_federal { get; set; }





    





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


     public virtual  ICollection<ferias_locales_banners> ferias_locales_banners { get; set; }  
  

    }