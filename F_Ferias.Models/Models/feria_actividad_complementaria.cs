using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class feria_actividad_complementaria {
        [Key]
        public int Id { get; set; }
        public int  id_feria { get; set; }
        public int  id_actividad_complementaria { get; set; }   

        [ForeignKey("id_feria")]
        public virtual ferias_empleo_local feria_empleo_local { get; set; }

        [ForeignKey("id_actividad_complementaria")]
        public virtual actividades_complementarias actividad_complementaria { get; set; }
    }

