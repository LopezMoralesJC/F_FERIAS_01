using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;
using F_Ferias.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using F_Ferias.AccessData.IRepository;
using F_Ferias.AccessData;
using Microsoft.EntityFrameworkCore;

namespace F_Ferias.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context , IContenedorTrabajo contenedorTrabajo , UserManager<ApplicationUser> userManager , RoleManager<ApplicationRole> roleManager, IConfiguration configuration) {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _contenedorTrabajo = contenedorTrabajo;   
            _context = context;
        }




        [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Register model) {
            var user = new ApplicationUser { UserName = model.Username };
            var result = await _userManager.CreateAsync(user, model.Password);

            if(result.Succeeded){
                return Ok(new { message = "El usuario se registro correctamente." });
            }
            return BadRequest(result.Errors);
        }





        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login model) {
            var user = await _userManager.FindByNameAsync(model.Username);
            if(user != null && await _userManager.CheckPasswordAsync(user, model.Password)){
                var UserRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim> 
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName!),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    
                };
                authClaims.AddRange(UserRoles.Select(role => new Claim(ClaimTypes.Role, role)));

                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    expires: DateTime.Now.AddMinutes(double.Parse(_configuration["Jwt:ExpiryMinutes"]!)),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!)),
                    SecurityAlgorithms.HmacSha256
                ));
                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }
        return Unauthorized();
        }

        [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("add-role")]
        public async Task<IActionResult>  AddRole([FromBody] string role) {
            if(!await _roleManager.RoleExistsAsync(role)){
                var result = await _roleManager.CreateAsync(new ApplicationRole(role));
                // var result = await _roleManager.CreateAsync(new IdentityRole(role));
                if(result.Succeeded){
                    return Ok(new { message = "El Rol fue creado exitosamente"});
                }
                return BadRequest(result.Errors);
            }
            return BadRequest("El rol ya existe");
        }

        [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] UserRole model){
            var user = await _userManager.FindByNameAsync(model.Username);

            if(user == null) {
                return BadRequest("Usuario no encontrado");
            }

            var result = await _userManager.AddToRoleAsync(user, model.Role);

            if(result.Succeeded){
                return Ok(new {message = "Rol asignado correctamente"});
            }
            return BadRequest(result.Errors);
        }








    [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
    [HttpGet("return-data_funcionary")]
    public IActionResult GetCurrentUSerRole([FromBody] string email) {
        if (User.Identity.IsAuthenticated) {

             string UserName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var data = _contenedorTrabajo.c_FUNCIONARIOS_PORTALEMPLEO_Repository.Get_FUNCIONARIOS_PORTALEMPLEO(email);
            //    return Ok(new { message = "Si estas autenticado ::: " + UserName});
            return Ok(data);
        }

        return BadRequest("Usuario no encontrado o aun no estas autenticado");

    }



    
    [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
    [HttpGet("getData_user")]
     public IActionResult getUserData([FromBody] string email) {
         if (User.Identity.IsAuthenticated) {
          var userDb = _context.ApplicationUser.FirstOrDefault(u => u.Email == email);
            return Ok(userDb);
         }
       
             return BadRequest("Usuario no encontrado con id o aun no estas autenticado");
       
     } 


    [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
    [HttpPost("send-tokken-data")]
      public async Task<IActionResult> SendTokenUsuario([FromBody] Login.User_Data model) {
          if (User.Identity.IsAuthenticated) {
                var userDb = await _context.ApplicationUser.FirstOrDefaultAsync(u => u.Email == model.email);
                
            if(userDb == null){
                 return BadRequest("Usuario no encontrado");
            }
                 userDb.Token = model.token;
                await _context.SaveChangesAsync();
                return Ok(new {message = "Token actualizado correctamente"});
            
          }
            return BadRequest("Usuario no encontrado con id o aun no estas autenticado");
     }
}