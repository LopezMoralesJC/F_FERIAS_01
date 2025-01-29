using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace F_Ferias.Models.Models;

    public class ferias_locales_banners
    {
        [Key]
        public int id { get; set; }	

        public string feria_logo_ruta { get; set; } // 

        public string nombre_feria_logo_ruta { get; set; }
        
        public int id_feria_local { get; set; }	

        


    //     // FK
         [ForeignKey("id_feria_local")]
          public virtual ferias_empleo_local Id_feria_local_banner_FK { get; set; }
   
   
   
    }
