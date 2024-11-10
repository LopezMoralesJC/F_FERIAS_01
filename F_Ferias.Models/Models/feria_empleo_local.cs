using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.Models.Models;
    public class ferias_empleo_local {

    [Key]
    public int id { get; set; }
    public string  titulo { get; set; }
    public string  comentario { get; set; }
    public string  direccion { get; set; }
    public int id_ubicacion { get; set; }


    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_ini { get; set; }
    
    [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de recepcion*:")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime fecha_fin { get; set; }

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





    public int user_create { get; set; }       // FK USUARIO
    public int? user_upddel { get; set; }   // FK USUARIO
    public int estatus { get; set; }  // FK
    public bool es_nacional { get; set; }
    public int? id_feria_nacional { get; set; } // FK
    public int modalidad { get; set; }         // FK
    public bool es_usne { get; set; }
    public bool es_osne { get; set; }
    public int id_entidad { get; set; }        // FK
    public int id_unidadresponsable { get; set; } // FK



    [System.ComponentModel.DataAnnotations.Display(Name = "Hora Fin*:")]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Time)]
    public DateTime hora_inicio { get; set; }
    
    [System.ComponentModel.DataAnnotations.Display(Name = "Hora Fin*:")]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Time)]
    public DateTime hora_fin { get; set; }



    public bool es_virtual { get; set; }
    public string  plataforma { get; set; }
    public string  plataforma_evento { get; set; }
    public string  plataforma_contrasena { get; set; }
    public string  plataforma_url { get; set; }

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


    public int id_tipo_recurso { get; set; } // FK
    public int? id_actividad_complementaria { get; set; } // FK
    public string  otra_actividad { get; set; }
    public string  otra_tipo_recurso { get; set; }
    public int zona { get; set; }
    public int vialidad { get; set; }
    public int asentamiento { get; set; }




    public int clasificacion { get; set; }   // FK
    public int actividad_economica { get; set; } // FK
        public string otra_actividad_economica { get; set; }
    public int tipo_evento { get; set; } // FK
    public int poblacion_especifica { get; set; }  // FK
    public string otros_tipo_poblacion { get; set; }

    public bool instalacion_nuevas_empresas { get; set; }
    public bool puesto_nueva_creacion { get; set; }
    public bool mano_obra_emporada { get; set; }
    public bool rotacion_personal { get; set; }

    public bool otra_justificacion { get; set; }
    public string otros_tipo_justificacion { get; set; }
    public int asiste_empresas { get; set; }
    public int asiste_oferta_empleo { get; set; }
    public int asiste_solicitan_empleo { get; set; }
    public int asiste_solicitan_colocado { get; set; }
    public byte feria_logo { get; set; }
    public bool misma_cede { get; set; }
    public bool publicacion { get; set; }
    public int id_feriatamanio { get; set; } // FK
    public string sede_evento { get; set; }

    public int? id_feria_inversion { get; set; } // FK
    public bool notificacion_enviada { get; set; }






    // CLAVES FORANEAS  ---------------------------------------------------------------------------------

    //    [ForeignKey("")]
    //     public virtual ferias_estatus estatus_feria { get; set; }


    [ForeignKey("user_create")]
    public virtual ApplicationUser usuario_Inserto { get; set; }

    [ForeignKey("user_upddel")]
    public virtual ApplicationUser usuario_Actualizo { get; set; }

    [ForeignKey("estatus")]
    public virtual ferias_estatus estatus_feria_asociado { get; set; }

    [ForeignKey("id_feria_nacional")]
    public virtual ferias_nacional id_feria_nacional_asociado { get; set; }

    [ForeignKey("modalidad")]
    public virtual feria_modalidad id_modalidad_asociado { get; set; }
    

    [ForeignKey("id_entidad")]
    public virtual entidad id_entidad_asociado { get; set; }
    
    [ForeignKey("id_unidadresponsable")]
     public virtual abc_directorio id_unidad_responsable_asociada_FK { get; set; }

    [ForeignKey("id_tipo_recurso")]
    public virtual tipo_recurso id_tipo_recurso_asociado { get; set; }

    [ForeignKey("id_actividad_complementaria")]
    public virtual tipo_recurso id_actividad_complementaria_asociado { get; set; }

    [ForeignKey("clasificacion")]
    public virtual clasificacion id_clasificacion_asociado { get; set; }

    [ForeignKey("actividad_economica")]
    public virtual actividad_economica_ferias id_actividad_economica_asociado { get; set; }

    [ForeignKey("tipo_evento")]
    public virtual tipo_evento_ferias id_tipo_evento_asociado { get; set; }

    [ForeignKey("poblacion_especifica")]
    public virtual poblacion_especifica id_poblacion_especifica_asociado { get; set; }

    [ForeignKey("id_feriatamanio")]
    public virtual feria_tamanio id_feriatamanio_asociado { get; set; }
    
    [ForeignKey("id_feria_inversion")]
    public virtual feria_inversion id_feria_inversion_asociado { get; set; }
    
    

    }