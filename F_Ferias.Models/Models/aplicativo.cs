using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models
{
    public class aplicativo
    {
        [Key]
        public int Id { get; set; }
        public string descripcion { get; set; }   
    }
}