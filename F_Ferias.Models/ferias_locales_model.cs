using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;
using Microsoft.AspNetCore.Http;

namespace F_Ferias.Models
{
    public class ferias_locales_model
    {
        public ferias_empleo_local ferias_empleo_local { get; set; }

        public add_Feria_local add_Feria_local { get; set; }
    }




     public class add_Feria_local {
     public int modalidad_feria { get; set; }
     public int modalidad_feria_value { get; set; }  // Presencial 1  o Virtual 2
     public bool publicar_portal_empleo { get; set; } // TRUE O FALSE
     public int tamano_feria{ get; set; }



     public int sector_economico { get; set; }
     public string otra_Actividad { get; set; } 


     public int tipo_poblacion { get; set; } 
     public int poblacion_especifica { get; set; }
     public string otra_poblacion { get; set; }



     public int justificacion_feria { get; set; }
     public string otra_justificacion { get; set; }




     public int o_contador__01 { get; set; }
     public int o_contador__02 { get; set; }
     public int o_contador__03 { get; set; }
     public int o_contador__04 { get; set; }




     public string tipo_usuario_usne_osne_value { get; set; }
     public string Participa_Feria_Nacional_value { get; set; }
     public int id_Feria_Nacional_Participa_Feria_Nacional { get; set; }

     public string nombre_feria { get; set; }

     public int id_entidad_value { get; set; }  // 
     public int id_unidad_responsable_value { get; set; }






     [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
     [DataType(DataType.Time)]
     public DateTime hora_inicio_value { get; set; }


     [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
     [DataType(DataType.Time)]
     public DateTime hora_fin_value { get; set; }



     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_inicio_value { get; set; }

     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_fin_value { get; set; }



     public bool unidad_responsable_OSNE { get; set; } // TRUE O FALSE

     public string cp_entidad_feria_local { get; set; }

     public int entidad_federativa_feria_local { get; set; } // dONDE SE LLEVARA A CABO
     public int municipio_alcaldia_feria_local { get; set; }

     public string colonia_feria_local { get; set; }

     public int tipo_vialidad_feria_local { get; set; }


     public string sede_evento_feria_local { get; set; }
     public string calle_feria_local { get; set; }
     public string numero_exterior_feria_local { get; set; }
     public string num_interior { get; set; }
     public string referencias_calles_feria_local { get; set; }


    //  [NotMapped]
    //  public IFormFile File { get; set; }




     [DefaultValue("No Aplica")]
     public string nombre_plataforma_virtual { get; set; }
     [DefaultValue("No Aplica")]
     public string id_plataforma_virtual { get; set; }
     [DefaultValue("No Aplica")]
     public string url_plataforma_virtual { get; set; }
     [DefaultValue("No Aplica")]
     public string contrasena_plataforma_virtual { get; set; }




     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_publicacion { get; set; }

     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_pre_registro_participacion_empresas { get; set; }



     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_pre_registro_participacion_buscadores_empleo { get; set; }

     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_máxima_de_importación_de_asistencia { get; set; }

     [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [DataType(DataType.Date)]
     public DateTime fecha_maxima_colocacion_participantes { get; set; }


     public bool checked_otras_actividades_talleres { get; set; } // TRUE O FALSE

     public string input_otra_actividad { get; set; }

     public string radio_inversion_valor { get; set; }





     public float number_1_Estatales { get; set; }
     public float number_2_Estatales { get; set; }
     public float number_3_Estatales { get; set; }
     public float number_4_Estatales { get; set; }
     public float number_5_Estatales { get; set; }

     public string _Gastos_de_promocion_difucion_Estatales { get; set; }
     public string _Gastos_de_acondicionamiento_del_local_Estatales { get; set; }
     public string _Gastos_de_infraestructura_de_computo_Estatales { get; set; }
     public string _Gastos_de_alquiler_Estatales { get; set; }
     public string _Gastos_de_servicios_de_videoconferencias_Estatales { get; set; }



     public float number1_Federales { get; set; }
     public float number2_Federales { get; set; }
     public float number3_Federales { get; set; }
     public float number4_Federales { get; set; }
     public float number5_Federales { get; set; }

     public string Gastos_de_promocion_difucion_Federales_Federales { get; set; }
     public string Gastos_de_acondicionamiento_del_local_Federales { get; set; }
     public string Gastos_de_infraestructura_de_computo_Federales { get; set; }
     public string Gastos_de_alquiler_Federales { get; set; }
     public string Gastos_de_servicios_de_videoconferencias_Federales { get; set; }




 }
}