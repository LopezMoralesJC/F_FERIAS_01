using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models
{
    public class Estatus
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int  Id { get; set; }
        
        
        public int value { get; set; }
        
        public string descripcion { get; set; }
        
        
    }
}