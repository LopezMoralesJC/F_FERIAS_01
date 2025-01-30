using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace F_Ferias.Models.Identity;

    public class ApplicationUser : IdentityUser<int> {
        
          public  int estatus { get; set; }

          public string Token { get; set; }

          public int? id_perfil_asignado { get; set; }


          [ForeignKey("id_perfil_asignado")]
          public virtual Perfiles id_perfiñ_FK{ get; set; }

    }
