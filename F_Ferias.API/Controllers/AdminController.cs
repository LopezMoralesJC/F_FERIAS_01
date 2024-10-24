using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;
using F_Ferias.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace F_Ferias.API.Controllers
{
    [Authorize(Roles = "Administrador Consejero Laboral")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

         private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AdminController(UserManager<ApplicationUser> userManager , RoleManager<ApplicationRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;   
        }



        [HttpGet]
        public IActionResult Get() {
            return Ok("Tu tienes aceeso como Administrador/Administrador Consejero Laboral");
        }

    }

    



}