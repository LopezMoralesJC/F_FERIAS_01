using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace F_Ferias.Models.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {

        public ApplicationRole() { }
        public ApplicationRole(string role) 
        {
            Name = role;
        }


    }
}