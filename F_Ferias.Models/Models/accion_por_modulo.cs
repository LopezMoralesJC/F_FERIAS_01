using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class accion_por_modulo
    {
        [Key]
        public int Id { get; set; }
        public int id_modulo { get; set; }
        public string  descripcion { get; set; }   




       [ForeignKey("id_modulo")]
       public virtual modulo Id_modulo_FK { get; set; }

    }