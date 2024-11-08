using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models
{
    public class tipo_propietario {
        [Key]
        public int Id { get; set; }
        public int descripcion { get; set; }
        public int estatus { get; set; } 
    }
}