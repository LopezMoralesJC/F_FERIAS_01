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
using F_Ferias.AccessData.Repository;
using F_Ferias.Models.Models.Modelos_API;
using F_Ferias.Models;
using System.Text.Json.Serialization;
using System.Diagnostics;

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




        // Identity

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
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

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
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

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
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



    [HttpGet("get-users-role")]
    public IActionResult getAllUsers()
    {

        var data = _contenedorTrabajo.applicationUserRepository.GetAll();
        return Ok(data);

    }
















    // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
    [Authorize]
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


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpGet("getData_user")]
        public IActionResult getUserData([FromBody] string email) {
            if (User.Identity.IsAuthenticated) {
            var userDb = _context.ApplicationUser.FirstOrDefault(u => u.Email == email);
                return Ok(userDb);
            }

                return BadRequest("Usuario no encontrado con id o aun no estas autenticado");

        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
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


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpGet("get-listado-entidades")]
        public IActionResult getEntidades() {
            // if (User.Identity.IsAuthenticated) {
                var entidadesDb = _contenedorTrabajo.entidadesRepository.Get_entidades();
                return Ok(entidadesDb);
            // }
            // return BadRequest("No se pudieron obtener las entidades");
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




































         // Ferias Nacionales ---------------------------------------------------------------------------


        // [Authorize(Roles = "Administrador Consejero Laboral")]
        [HttpPost("add-feria-na")]
        public async Task<IActionResult> AddFeria(ferias_nacional feria) {
            try {
                // if (User.Identity.IsAuthenticated) {
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
                    feria_nac_banner.feria_logo_ruta = filePathGeneral + "" + NombreArchivo; // rutaDestinoCompleta;
                    feria_nac_banner.nombre_feria_logo_ruta =  feria.file__name;
                    _contenedorTrabajo.ferias_Nacionales_BannerRepository.Add(feria_nac_banner);
                    _contenedorTrabajo.Save();
                    //  string base64 = Convert.ToBase64String(feria.feria_logo_banner);
                     await System.IO.File.WriteAllBytesAsync(string.Format("{0}" ,rutaDestinoCompleta  ), feria.feria_logo_banner);

                     return Ok("Ruta - > " + exist);

                // }
                // else
                // {
                //     return BadRequest("No tienes las credenciales correctas");
                // }
            }
            catch (Exception e)
            {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }

        }




        // [Authorize(Roles = "Administrador Consejero Laboral")]
        [Authorize]
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

        // [Authorize(Roles = "Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("pagination-feria-na__2")]
        public IActionResult get__Pagination__fna_async([FromBody] int pageNumber) {

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


        // [Authorize(Roles = "Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("get_feria_na")]
        public IActionResult get__feria_na([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository.GetFirstOrDefault(
                        IncludeProperties: "Id_usuario_Inserto_FK,Id_usuario_Actualizo_FK,Id_FKestatus_feria_FK,ferias_nac_FK,", filter: p => p.id == id );
                        
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpGet("get_ferias_na")]
        public IActionResult get__ferias_na() {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository
                    .GetListaFeriasNacionales();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("get_ferias_na_osne")]
        public IActionResult get__ferias_na_osne([FromBody] int id) {
            try {
            //   x.Name->>'value' like '%@search%'
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository.GetAll(filter: p => p.id == id);
                    return Ok(data_consulta);
            
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            // return Ok(new { message = "Se recibio la informacion" });
        }


        [HttpPost("get_ferias_na_osne_2")]
        public IActionResult get__feria_na_osne_2([FromBody] int id) {
            try {
            //   x.Name->>'value' like '%@search%'
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository.GetAll(
                    filter: p => p.data_entidades_selection.Contains(id) && p.estatus == 5
                    
                    );

            return Ok(data_consulta);
            
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            
            }
            // return Ok(new { message = "Se recibio la informacion" }); .Where(entity=> entity.JsonObject[PathInsideJson] == filterValue)
        }















        // https://localhost:7193/api/Account/update-feria-nacional
        [HttpPost("update-feria-nacional")]
        public async Task<IActionResult> Update_Feria_nacional(F_Ferias.Models.Models.ferias_nacional feria)    {
        try
        {
            CultureInfo ci = new CultureInfo("es-ES");
            DateTime sqlFormattedDate = (DateTime)DateTime.UtcNow; ;
            string fecha_titulo = sqlFormattedDate.ToString("yyyyMMddHHmmssfffffff");
            string YFormateada = sqlFormattedDate.ToString("yyyy", ci);
            string MFormateada = sqlFormattedDate.ToString("MMMM", ci);
            string filePathGeneral = "wwwroot\\Uploads\\fna__uploads" + string.Format("\\{0}\\{1}", YFormateada, MFormateada + "\\");
            string NombreArchivo = fecha_titulo + "_" + feria.file__name;
            string rutaDestinoCompleta = Path.Combine(_environment.ContentRootPath + filePathGeneral, NombreArchivo);
            bool exist = Directory.Exists(_environment.ContentRootPath + filePathGeneral);

            if (!Directory.Exists(_environment.ContentRootPath + filePathGeneral))
            {
                Directory.CreateDirectory(_environment.ContentRootPath + filePathGeneral);
            }
            else { }


            _contenedorTrabajo.feriaNacionalRepository.UpdateFeriaNacional(feria);
            _contenedorTrabajo.Save();
            int dataInserAct = feria.id;


            // -------------------------------------------------------------------------------

            if(feria.feria_logo_banner != null && feria.file__name != null){ 
                var feria_nacional_banner = new  F_Ferias.Models.Models.ferias_nacionales_banner();
                feria_nacional_banner.id_feria_nacional = dataInserAct;
                feria_nacional_banner.feria_logo_ruta = filePathGeneral + "" + NombreArchivo; // rutaDestinoCompleta;
                feria_nacional_banner.nombre_feria_logo_ruta =  feria.file__name;
                _contenedorTrabajo.feria_Nacional_BannnerRepository.Add(feria_nacional_banner);
                _contenedorTrabajo.Save();

                await System.IO.File.WriteAllBytesAsync(string.Format("{0}" ,rutaDestinoCompleta  ), feria.feria_logo_banner);
             }



            return Ok("SE Actualizo CORRECTAMENTE con ID : " + dataInserAct);

            //  return BadRequest("No se pueden consultar , no estas authenticado");


        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return BadRequest("No se pueden consultar :  " + e.Message);
        }
    }













































  // Ferias Locales ---------------------------------------------------------------------------


        [HttpPost("add-feria-local")]
        public async Task<IActionResult> Add_Feria_local(F_Ferias.Models.Models.ferias_empleo_local feria)    {
        try
        {
            CultureInfo ci = new CultureInfo("es-ES");
            DateTime sqlFormattedDate = (DateTime)DateTime.UtcNow; ;
            string fecha_titulo = sqlFormattedDate.ToString("yyyyMMddHHmmssfffffff");
            string YFormateada = sqlFormattedDate.ToString("yyyy", ci);
            string MFormateada = sqlFormattedDate.ToString("MMMM", ci);
            string filePathGeneral = "wwwroot\\Uploads\\flc__uploads" + string.Format("\\{0}\\{1}", YFormateada, MFormateada + "\\");
            string NombreArchivo = fecha_titulo + "_" + feria.file__name;
            string rutaDestinoCompleta = Path.Combine(_environment.ContentRootPath + filePathGeneral, NombreArchivo);
            bool exist = Directory.Exists(_environment.ContentRootPath + filePathGeneral);

            if (!Directory.Exists(_environment.ContentRootPath + filePathGeneral))
            {
                Directory.CreateDirectory(_environment.ContentRootPath + filePathGeneral);
            }
            else { }

            feria.cantidad_total_federal = 0;
            feria.cantidad_total_est = 0;
            feria.cantidad_total_est = feria.cantidad_promocion_est + feria.cantidad_acondicionamiento_est
            + feria.cantidad_infraestructura_computo_est + feria.cantidad_alquiler_est 
            + feria.cantidad_servicios_videoconferencias_est;
            feria.cantidad_total_federal = feria.cantidad_promocion_federal + feria.cantidad_acondicionamiento_federal
            + feria.cantidad_infraestructura_computo_federal + feria.cantidad_alquiler_federal +
            feria.cantidad_servicios_videoconferencias_federal;
            _contenedorTrabajo.feriaLocalRepository.Add(feria);
            _contenedorTrabajo.Save();
            int dataInserAct = feria.id;


            // -------------------------------------------------------------------------------

            var feria_local_banner = new  ferias_locales_banners();
            feria_local_banner.id_feria_local = dataInserAct;
            feria_local_banner.feria_logo_ruta = filePathGeneral + "" + NombreArchivo; // rutaDestinoCompleta;
            feria_local_banner.nombre_feria_logo_ruta =  feria.file__name;
            _contenedorTrabajo.ferias_locales_bannerRespository.Add(feria_local_banner);
            _contenedorTrabajo.Save();

              await System.IO.File.WriteAllBytesAsync(string.Format("{0}" ,rutaDestinoCompleta  ), feria.feria_logo_banner);

            return Ok("SE INSERTO CORRECTAMENTE");

            //  return BadRequest("No se pueden consultar , no estas authenticado");


        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return BadRequest("No se pueden consultar :  " + e.Message);
        }
    }
 

        [HttpPost("update-feria-local")]
        public async Task<IActionResult> Update_Feria_local(F_Ferias.Models.Models.ferias_empleo_local feria)    {
        try {
            CultureInfo ci = new CultureInfo("es-ES");
            DateTime sqlFormattedDate = (DateTime)DateTime.UtcNow; ;
            string fecha_titulo = sqlFormattedDate.ToString("yyyyMMddHHmmssfffffff");
            string YFormateada = sqlFormattedDate.ToString("yyyy", ci);
            string MFormateada = sqlFormattedDate.ToString("MMMM", ci);
            string filePathGeneral = "wwwroot\\Uploads\\flc__uploads" + string.Format("\\{0}\\{1}", YFormateada, MFormateada + "\\");
            string NombreArchivo = fecha_titulo + "_" + feria.file__name;
            string rutaDestinoCompleta = Path.Combine(_environment.ContentRootPath + filePathGeneral, NombreArchivo);
            bool exist = Directory.Exists(_environment.ContentRootPath + filePathGeneral);

            if (!Directory.Exists(_environment.ContentRootPath + filePathGeneral))
            {
                Directory.CreateDirectory(_environment.ContentRootPath + filePathGeneral);
            }
            else { }

            feria.cantidad_total_federal = 0;
            feria.cantidad_total_est = 0;
            feria.cantidad_total_est = feria.cantidad_promocion_est + feria.cantidad_acondicionamiento_est
            + feria.cantidad_infraestructura_computo_est + feria.cantidad_alquiler_est 
            + feria.cantidad_servicios_videoconferencias_est;
            
            feria.cantidad_total_federal = feria.cantidad_promocion_federal + feria.cantidad_acondicionamiento_federal
            + feria.cantidad_infraestructura_computo_federal + feria.cantidad_alquiler_federal +
            feria.cantidad_servicios_videoconferencias_federal;
            _contenedorTrabajo.feriaLocalRepository.UpdateFeriaLocal(feria);
            _contenedorTrabajo.Save();
            int dataInserAct = feria.id;


            // -------------------------------------------------------------------------------

            if(feria.feria_logo_banner != null && feria.file__name != null){ 
                var feria_local_banner = new  ferias_locales_banners();
                feria_local_banner.id_feria_local = dataInserAct;
                feria_local_banner.feria_logo_ruta = filePathGeneral + "" + NombreArchivo; // rutaDestinoCompleta;
                feria_local_banner.nombre_feria_logo_ruta =  feria.file__name;
                _contenedorTrabajo.ferias_locales_bannerRespository.Add(feria_local_banner);
                _contenedorTrabajo.Save();

                await System.IO.File.WriteAllBytesAsync(string.Format("{0}" ,rutaDestinoCompleta  ), feria.feria_logo_banner);
             }



            return Ok("SE Actualizo CORRECTAMENTE con ID : " + dataInserAct);

            //  return BadRequest("No se pueden consultar , no estas authenticado");


        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            return BadRequest("No se pueden consultar :  " + e.Message);
        }
    }



        [HttpGet("get-ferias-locales")]
        public async Task<IActionResult> get_Ferias_locales() {

            var data = await _contenedorTrabajo.feriaLocalRepository.GetAllAsync(includeProperties:"ferias_locales_banners,id_unidad_responsable_asociada_FK,"
                            +"id_entidad_feria_presencial_ubicacion,id_entidad_asociado,id_feria_nacional_asociado," 
                            +"usuario_Actualizo,usuario_Inserto,justificacion_feria_local,id_poblacion_especifica_asociado," 
                            +"id_tipo_evento_asociado,id_actividad_economica_asociado,id_clasificacion_asociado,"
                            +"id_feriatamanio_asociado,id_modalidad_asociado,estatus_feria_asociado,id_modalidad_asociado,"
                            +"id_tipo_recurso_asociado" // Feria_Inversion_FK,id_actividad_complementaria_asociado_FK,
                            );
            return Ok(data);

        }

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("get-feria-local")]
        public IActionResult get_Feria_local([FromBody] int id) {
            var data = _contenedorTrabajo.feriaLocalRepository.GetAll_2(
                includeProperties: "ferias_locales_banners,id_unidad_responsable_asociada_FK,"
                                    + "id_entidad_feria_presencial_ubicacion,id_entidad_asociado,id_feria_nacional_asociado,"
                                    + "usuario_Actualizo,usuario_Inserto,justificacion_feria_local,id_poblacion_especifica_asociado,"
                                    + "id_tipo_evento_asociado,id_actividad_economica_asociado,id_clasificacion_asociado,"
                                    + "id_feriatamanio_asociado,id_modalidad_asociado,estatus_feria_asociado,id_modalidad_asociado,"
                                    + "id_tipo_recurso_asociado" //Feria_Inversion_FK,id_actividad_complementaria_asociado_FK,
                                    , filter: p => p.id == id );
            return Ok(data);

        }



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("pagination-feria-local")]
        public async Task<IActionResult> get__Pagination__flc([FromBody] int pageNumber) {
            var feria =  _contenedorTrabajo.feriaLocalRepository.GetAll_2(includeProperties:"ferias_locales_banners,id_unidad_responsable_asociada_FK,"
                                                                                                  +"id_entidad_feria_presencial_ubicacion,id_entidad_asociado,id_feria_nacional_asociado," 
                                                                                                  +"usuario_Actualizo,usuario_Inserto,justificacion_feria_local,id_poblacion_especifica_asociado," 
                                                                                                  +"id_tipo_evento_asociado,id_actividad_economica_asociado,id_clasificacion_asociado,"
                                                                                                  +"id_feriatamanio_asociado,id_modalidad_asociado,estatus_feria_asociado,id_modalidad_asociado,"
                                                                                                  +"id_tipo_recurso_asociado"  // Feria_Inversion_FK,id_actividad_complementaria_asociado_FK,
                                                                                                   );
              // Ensure pageNumber is at least 1
            if (pageNumber < 1)
            {
                pageNumber = 1;
            }
             int pageSize = 10;
             return Ok(await PaginatedList<ferias_empleo_local>.CreateAsync((IQueryable<ferias_empleo_local>)feria, pageNumber, pageSize ));
        }



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("pagination-feria-local-entidad")]
        public async Task<IActionResult> get__Pagination__flc_entidad(modelData modelData ) {
            var feria =  _contenedorTrabajo.feriaLocalRepository.GetAll_2(
                includeProperties:"ferias_locales_banners,id_unidad_responsable_asociada_FK,"
                +"id_entidad_feria_presencial_ubicacion,id_entidad_asociado,id_feria_nacional_asociado," 
                +"usuario_Actualizo,usuario_Inserto,justificacion_feria_local,id_poblacion_especifica_asociado," 
                +"id_tipo_evento_asociado,id_actividad_economica_asociado,id_clasificacion_asociado,"
                +"id_feriatamanio_asociado,id_modalidad_asociado,estatus_feria_asociado,id_modalidad_asociado,"
                +"id_tipo_recurso_asociado"  , filter: p => p.id_entidad == modelData.id_entidad);
                  // Feria_Inversion_FK,      ,id_actividad_complementaria_asociado_FK,                                                                          
              // Ensure pageNumber is at least 1
            if (modelData.pagenumber < 1)
            {
                modelData.pagenumber = 1;
            }
             int pageSize = 10;
             return Ok(await PaginatedList<ferias_empleo_local>
             .CreateAsync((IQueryable<ferias_empleo_local>)feria, modelData.pagenumber, pageSize ));
        }









































        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("get_unidades_res")]
        public IActionResult get__unidades_responsables([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.abcDirectorioRepository.GetAllUnidadesResponsables(id);
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        // [Authorize]
        [HttpGet("get-all-vialidades")]
        public IActionResult getVialidades() {
                try {
                if (User.Identity.IsAuthenticated) {
                            // var data__vialidad = _context.Set<cp_cepomex_mexico>().GroupBy(e => new{e.c_tipo_asenta}).Select(g => g.FirstOrDefault());
                            return Ok(_contenedorTrabajo.cpCepomexRepository.get__all__vialidades());
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
        }

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        // [Authorize]
        [HttpPost("get_unique_vialidad")]
        public IActionResult get__unique_vialidad([FromBody] int id) {

            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.cpCepomexRepository.get_vialidad_unique(id);
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        // [Authorize]
        [HttpPost("get-filter-municipios")]
        public IActionResult getMunicipios([FromBody] int id) {
                try {
                if (User.Identity.IsAuthenticated) {
                return Ok(_contenedorTrabajo.cpCepomexRepository.get__all__municipios(id));
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
        }


        // [Authorize]
        [HttpPost("get-filter-municipio")]
        public IActionResult get_Municipio([FromBody] GetColonias.obtenerColonias model) {
                try {
                if (User.Identity.IsAuthenticated) {
                // return Ok(_contenedorTrabajo.cpCepomexRepository
                // .get_municipio_unique(model.IdEntidad , model.IdMunicipio));
               return Ok(_context.cp_Cepomex_Mexico.Where(c => c.id_entidad ==model.IdEntidad
               
               && c.c_mnpio == model.IdMunicipio ).FirstOrDefault());
            
              
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
        } 



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("get-filter-colonias")]
        public IActionResult getColonias([FromBody] GetColonias.obtenerColonias model) {
        try {
                if (User.Identity.IsAuthenticated) {
                return Ok(_contenedorTrabajo.cpCepomexRepository.get__all__colonias(model.IdEntidad , model.IdMunicipio).OrderBy(a => a.d_asenta));
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
        }



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        // [Authorize]
        [HttpPost("get-filter-entidades_cp")]
        public IActionResult getEntidadCp([FromBody] string id) {
        try {
                if (User.Identity.IsAuthenticated) {
                return Ok(_contenedorTrabajo.cpCepomexRepository.get__cp__entidades(id));
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        // [Authorize]
        [HttpPost("get-filter-colonias_cp")]
        public IActionResult getColoniasCp([FromBody] string id) {
        try {
                if (User.Identity.IsAuthenticated) {
                return Ok(_contenedorTrabajo.cpCepomexRepository.get__all__colonias_cp(id));
                }else {
                    return BadRequest("No estas autenticado");
                }
            } catch(Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [HttpPost("get-filter-colonia-cp")]
        public IActionResult getdataCp_colonia([FromBody] GetColonias.obtenercolonia_cp obtenercolonia_Cp) {
                try {
                        // if (User.Identity.IsAuthenticated) {
                        return Ok(_contenedorTrabajo.cpCepomexRepository.get__colonias__cp 
                        (obtenercolonia_Cp.cp  , obtenercolonia_Cp.colonia));
                        // }else {
                        //     return BadRequest("No estas autenticado");
                        // }
                    } catch(Exception e) {
                        return BadRequest("No se pueden consultar :  " + e.Message);
                    }
                }

        
        
        [HttpPost("get-filter-user-entidad")]
         public IActionResult getData_User_Entidad([FromBody] string email) {
            var usuario = (_contenedorTrabajo.c_FUNCIONARIOS_PORTALEMPLEO_Repository.Get_FUNCIONARIOS_PORTALEMPLEO(email));

             var entidadesDb = _contenedorTrabajo.entidadesRepository.Get_entidades_filter(usuario.id_entidad);

             return Ok(entidadesDb) ;



         }

        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-Validado-osne")]
        public IActionResult setOsne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaLocalRepository.GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 7;


                    _contenedorTrabajo.feriaLocalRepository.UpdateFeriaLocal(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }

      
        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-rechazado-osne")]
        public IActionResult setRechazarOsne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaLocalRepository.GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 8;
                    _contenedorTrabajo.feriaLocalRepository.UpdateFeriaLocal(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-reactivar_osne")]
        public IActionResult setReactivarOsne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaLocalRepository.GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 6;
                    _contenedorTrabajo.feriaLocalRepository.UpdateFeriaLocal(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-rechazar-usne")]
        public IActionResult setRechazaUsne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaLocalRepository.GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 4;
                    _contenedorTrabajo.feriaLocalRepository.UpdateFeriaLocal(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }




        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]}
        [Authorize]
        [HttpPost("set-feria-validar-feria-fna-usne")]
        public IActionResult set_validar_fna_Usne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository.
                    GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 5;
                    _contenedorTrabajo.feriaNacionalRepository.UpdateFeriaNacional(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }





        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-rechazar-feria-fna-usne")]
        public IActionResult set_feria_rechazar_feria_fna_usne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository.
                    GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 4;
                    _contenedorTrabajo.feriaNacionalRepository.UpdateFeriaNacional(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }


        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-reactivar-fna-usne")]
        public IActionResult set_feria_reactivar_fna_usne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaNacionalRepository.
                    GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 6;
                    _contenedorTrabajo.feriaNacionalRepository.UpdateFeriaNacional(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }



        // [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
        [Authorize]
        [HttpPost("set-feria-validado-usne")]
        public IActionResult setValidarUsne([FromBody] int id) {
            try {
                if (User.Identity.IsAuthenticated) {
                    var data_consulta = _contenedorTrabajo.feriaLocalRepository.GetFirstOrDefault(filter: p => p.id == id);
                    data_consulta.estatus = 5;
                    _contenedorTrabajo.feriaLocalRepository.UpdateFeriaLocal(data_consulta);
                    _contenedorTrabajo.Save();
                    return Ok(data_consulta);
                }
            } catch (Exception e) {
                return BadRequest("No se pueden consultar :  " + e.Message);
            }
            return Ok(new { message = "Se recibio la informacion" });
        }

 

} // End
