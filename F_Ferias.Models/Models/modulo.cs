using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;
    public class modulo {
        [Key]
        public int Id { get; set; }
        public int id_aplicativo { get; set; }
        public string  descripcion { get; set; }   
    
    
        // CLAVES FORANEAS 

        
    [ForeignKey("id_aplicativo")]
    public virtual aplicativo Id_aplicativo_FK { get; set; }

    }
