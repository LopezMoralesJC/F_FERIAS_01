using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using F_Ferias.AccessData.Data;
using F_Ferias.Models.Identity;
using F_Ferias.Models.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace F_Ferias.AccessData.Repository
{
    public class AutorizationService : IAutorizationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AutorizationService(UserManager<ApplicationUser> userManager ,
                                   RoleManager<ApplicationRole> roleManager,
                                                 IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;   
        }

        // private string GenerateToken(string idUsuario) {

        // }

        public Task<AutorizationResponce> DevolverToken(Login model)
        {
            throw new NotImplementedException();
        }
    }
}