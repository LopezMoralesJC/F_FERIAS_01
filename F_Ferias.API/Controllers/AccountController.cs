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
using System.Globalization;

namespace F_Ferias.API.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public AccountController(IWebHostEnvironment environment ,ApplicationDbContext context , IContenedorTrabajo contenedorTrabajo , UserManager<ApplicationUser> userManager , RoleManager<ApplicationRole> roleManager, IConfiguration configuration) {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _contenedorTrabajo = contenedorTrabajo;   
            _context = context;
             _environment = environment;
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


        [Authorize(Roles = "Administrador Consejero Laboral")]
        [HttpGet("get-listado-entidades")]
        public IActionResult getEntidades() {
            if (User.Identity.IsAuthenticated) {
                var entidadesDb = _contenedorTrabajo.entidadesRepository.Get_entidades();
                return Ok(entidadesDb);
            }
            return BadRequest("No se pudieron obtener las entidades");
        }

        [Authorize]
        [HttpGet("get-data-user-login-1")]
        public IActionResult getDataUser_1(int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                            var data__users = _contenedorTrabajo.c_FUNCIONARIOS_PORTALEMPLEO_Repository.Get_FUNCIONARIOS_PORTALEMPLEO(id);
                            return Ok(data__users);
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
    
        }

        [Authorize]
        [HttpPost("get-data-user-login-2")]
        public IActionResult getDataUser_2([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                            var data__users = _contenedorTrabajo.personaRepository.Get_Persona(id);
                            return Ok(data__users);
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            } 
        }




        [Authorize(Roles = "Administrador Consejero Laboral")]
        [HttpPost("add-feria-na")]
        public async Task<IActionResult> AddFeria(ferias_nacional feria) {
            try {
                if (User.Identity.IsAuthenticated) {
                    CultureInfo ci = new CultureInfo("es-ES");
                    DateTime sqlFormattedDate = (DateTime)feria.create_at;
                    string fecha_titulo = sqlFormattedDate.ToString("yyyyMMddHHmmssfffffff");
                    string YFormateada = sqlFormattedDate.ToString("yyyy", ci);
                    string MFormateada = sqlFormattedDate.ToString("MMMM", ci);
                    string filePathGeneral = "wwwroot\\Uploads\\fna__uploads" + string.Format("\\{0}\\{1}", YFormateada, MFormateada + "\\");
                    string NombreArchivo = fecha_titulo + "_" + feria.file__name;
                    string rutaDestinoCompleta = Path.Combine(_environment.ContentRootPath + filePathGeneral, NombreArchivo);
                    bool exist = Directory.Exists(_environment.ContentRootPath + filePathGeneral);

                    if (!Directory.Exists(_environment.ContentRootPath + filePathGeneral)) {
                        Directory.CreateDirectory(_environment.ContentRootPath + filePathGeneral);
                    }
                    else { }
                    _contenedorTrabajo.feriaNacionalRepository.Add(feria);
                    _contenedorTrabajo.Save();
                    int dataInserAct = feria.id;
                    var feria_nac_banner = new  ferias_nacionales_banner();
                    feria_nac_banner.id_feria_nacional = dataInserAct;
                    feria_nac_banner.feria_logo_banner = feria.feria_logo_banner;
                    feria_nac_banner.feria_logo_ruta = rutaDestinoCompleta;
                    feria_nac_banner.nombre_feria_logo_ruta =  feria.file__name;
                    _contenedorTrabajo.ferias_Nacionales_BannerRepository.Add(feria_nac_banner);
                    _contenedorTrabajo.Save();
                    //  string base64 = Convert.ToBase64String(feria.feria_logo_banner);
                     await System.IO.File.WriteAllBytesAsync(string.Format("{0}" ,rutaDestinoCompleta  ), feria.feria_logo_banner);

              return Ok("Ruta - > " + exist);

                }
                else
                {
                    return BadRequest("No tienes las credenciales correctas");
                }
            }
            catch (Exception e)
            {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }

        }



        [Authorize(Roles = "Administrador Consejero Laboral")]
        [HttpPost("pagination-feria-na")]
        public async Task<IActionResult> get__Pagination__fna([FromBody] int pageNumber) {
            var feria =  _contenedorTrabajo.feriaNacionalRepository.GetAll_2( includeProperties: "Id_usuario_Inserto_FK,Id_usuario_Actualizo_FK,Id_FKestatus_feria_FK,ferias_nac_FK");
              // Ensure pageNumber is at least 1
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }
             int pageSize = 10;
             return Ok(await PaginatedList<ferias_nacional>.CreateAsync((IQueryable<ferias_nacional>)feria, pageNumber, pageSize ));
        }


    [Authorize(Roles = "Administrador Consejero Laboral")]
    [HttpPost("pagination-feria-na__2")]
    public IActionResult get__Pagination__fna_async([FromBody] int pageNumber)
    {

        //  var totalRegistrosTotal = _context.DeptoTurnados.Where(p => p.IdArea == usuarioDb.id_dir_area).Count();
        var total_reg = _context.Ferias_Nacional.Count();
        int cantidadRegistros = 10;
        int OmitirRegistros = (pageNumber * cantidadRegistros) - cantidadRegistros;

        var consulta = _contenedorTrabajo.feriaNacionalRepository.GetPaginationAll(
                   includeProperties: "Id_usuario_Inserto_FK,Id_usuario_Actualizo_FK,Id_FKestatus_feria_FK,ferias_nac_FK",
                                                                            omitirRegistros: OmitirRegistros,
                                                                            cantidadRegistros: cantidadRegistros
                                                                        // orderBy: a =>a.OrderBy(a => a.id)
                                                                        );

        return Ok(new
        {
            draw = pageNumber,
            recordsTotal = total_reg,
            recordsFiltered = OmitirRegistros,
            data = consulta,
        });

    }
}
