using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace F_Ferias.Models.Identity;

    public class ApplicationUser : IdentityUser<int> {
        
          public  int estatus { get; set; }

          public string Token { get; set; }
    }
