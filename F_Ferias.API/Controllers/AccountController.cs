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

namespace F_Ferias.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager , RoleManager<ApplicationRole> roleManager, IConfiguration configuration) {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;   
        }

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
    
  
       [Authorize(Roles = "Administrador Consejero Laboral")]
       [HttpGet("return-role")]
        public async Task<IActionResult> GetCurrentUSerRoleAsync([FromBody] string email) {
           var user = await _userManager.FindByNameAsync(email);
           if(user == null) {
                return BadRequest("Usuario no encontrado");
            }

            var roles = await _userManager.GetRolesAsync(user);
            return Ok(roles);

        }
    }
