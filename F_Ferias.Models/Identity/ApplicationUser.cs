using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;
using Microsoft.AspNetCore.Identity;

namespace F_Ferias.Models.Identity;

    public class ApplicationUser : IdentityUser<int> {
        
          public  int estatus { get; set; }

          public string Token { get; set; }

          public int? id_perfil_asignado { get; set; }

          public int? id_funcionario_Portal_Empleo { get; set; }

          public int? id_entidad_federativa_pertenece { get; set; }


          [ForeignKey("id_perfil_asignado")]
          public virtual Perfiles id_perfiñ_FK{ get; set; }

          [ForeignKey("id_funcionario_Portal_Empleo ")]
          public virtual C_FUNCIONARIOS_PORTALEMPLEO id_funcionario_portal_emplep_FK{ get; set; }

         [ForeignKey("id_entidad_federativa_pertenece")]
          public virtual entidad id_entidad_federativa_FK{ get; set; }





    }
