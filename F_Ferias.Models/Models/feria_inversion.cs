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
        public string observacion_promocion  { get; set; }
        public float cantidad_promocion  { get; set; }
        public string observacion_acondicionamiento  { get; set; }
        public float cantidad_acondicionamiento  { get; set; }
        public string observacion_infraestructura_computo  { get; set; }
        public float cantidad_infraestructura_computo  { get; set; }
        public string observacion_alquiler  { get; set; }
        public float cantidad_alquiler  { get; set; }
        public string observacion_alimentos_bebidas  { get; set; }
        public float cantidad_alimentos_bebidas  { get; set; }


        public int id_tipo_recurso  { get; set; }
        public int estatus  { get; set; }
        public string observacion_promocion_est  { get; set; }
        public float cantidad_promocion_est  { get; set; }
        public string observacion_acondicionamiento_est  { get; set; }
        public float cantidad_acondicionamiento_est  { get; set; }
        public string observacion_infraestructura_computo_est  { get; set; }
        public float cantidad_infraestructura_computo_est  { get; set; }
        public string observacion_alquiler_est  { get; set; }
        public float cantidad_alquiler_est  { get; set; }
        public string observacion_alimentos_bebidas_est  { get; set; }
        public float cantidad_alimentos_bebidas_est  { get; set; }


        [ForeignKey("id_tipo_recurso")]
        public virtual tipo_recurso id_entidad_asociado_FK { get; set; }

        
    }
