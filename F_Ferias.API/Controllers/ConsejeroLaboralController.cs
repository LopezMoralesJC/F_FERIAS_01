using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace F_Ferias.API.Controllers {
    [Authorize(Roles = "Consejero Laboral,Administrador Consejero Laboral")]
    [ApiController]
    [Route("api/[controller]")]
    public class ConsejeroLaboralController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
            return Ok("Ya tienes acceso al controlador de Consejero Laboral ");
        }
    }
}