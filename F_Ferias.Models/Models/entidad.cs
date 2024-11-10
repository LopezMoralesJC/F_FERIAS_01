using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class entidad {

        [Key]
        public int Id { get; set; }
        public int Id_Pais { get; set; }
        public string  Descripcion { get; set; }
        public string Iniciales { get; set; }
        public int  Estatus { get; set; }  

    }
