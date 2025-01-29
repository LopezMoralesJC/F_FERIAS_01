using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class feria_inversion {

        [Key]
        public int id  { get; set; }


        public int id_tipo_recurso  { get; set; }

        public string observacion_recurso_estatal  { get; set; }

        public string observacion_promocion_estatal  { get; set; }
        public float cantidad_promocion_est  { get; set; }



        public string observacion_acondicionamiento_est  { get; set; }
        public float cantidad_acondicionamiento_est  { get; set; }



        public string observacion_infraestructura_computo_est  { get; set; }
        public float cantidad_infraestructura_computo_est  { get; set; }



        public string observacion_alquiler_est  { get; set; }
        public float cantidad_alquiler_est  { get; set; }


        public string observacion_servicios_videoconferencias_est  { get; set; }
        public float cantidad_servicios_videoconferencias_est  { get; set; }



        public float cantidad_total_est  { get; set; }



    
// -------------------------------------------------------------------------------------------

        public string observacion_recurso_federal  { get; set; }



        public string observacion_promocion_federal  { get; set; }
        public float cantidad_promocion_federal  { get; set; }



        public string observacion_acondicionamiento_federal  { get; set; }
        public float cantidad_acondicionamiento_federal  { get; set; }


        
        public string observacion_infraestructura_computo_federal  { get; set; }
        public float cantidad_infraestructura_computo_federal  { get; set; }


        public string observacion_alquiler_federal  { get; set; }
        public float cantidad_alquiler_federal  { get; set; }


        public string observacion_servicios_videoconferencias_federal  { get; set; }
        public float cantidad_servicios_videoconferencias_federal  { get; set; }

        public float cantidad_total_federal  { get; set; }  
    

        [ForeignKey("id_tipo_recurso")]
        public virtual tipo_recurso id_entidad_asociado_FK { get; set; }

        
    }
