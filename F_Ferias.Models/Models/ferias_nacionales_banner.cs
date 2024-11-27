using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models {
    public class ferias_nacionales_banner {
        [Key]
        public int id { get; set; }	
        [StringLength(1000)]
        public string feria_logo_ruta { get; set; } // 
        [StringLength(1000)]
        public string nombre_feria_logo_ruta { get; set; }
        
        public int id_feria_nacional { get; set; }	

        // public Byte feria_logo { get; set; } // Se insertara una imagen BLOB para almacenar en base
        public byte[] feria_logo_banner { get; set; } 
        // FK
       [ForeignKey("id_feria_nacional")]
        public virtual ferias_nacional Id_feria_na_banner_FK { get; set; }
    }
}