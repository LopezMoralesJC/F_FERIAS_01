using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models ;
    public class actividades_complementarias {
        [Key]
        public int Id { get; set; }
        public string  Descripcion { get; set; }
        public string  Estatus { get; set; }
        
    }
