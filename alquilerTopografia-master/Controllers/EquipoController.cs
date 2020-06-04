using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using alquilerTopografia_master.Models;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace equilerTopografia_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly EquipoService _eqService;
        public EquipoController(AlquilerContext context)
        {
            _eqService = new EquipoService(context);
        }

        // GET: api/Equipo
        [HttpGet]
        public IEnumerable<EquipoViewModel> Gets()
        {
            var equilers = _eqService.ConsultarTodosEquipo().Select(p => new EquipoViewModel(p));
            return equilers;
        }

        // POST: api/Equipo
        [HttpPost]
        public ActionResult<EquipoViewModel> Post(EquipoInputModel eqInput)
        {
            Equipo eq = MapearEquipo(eqInput);
            var response = _eqService.Guardar(eq);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Equipo);
        }

        
        //
        private Equipo MapearEquipo(EquipoInputModel Input)
        {
            var Equipo = new Equipo
            {
                Id = Input.Id,
                Nombre = Input.Nombre,
                Valor = Input.Valor,
                MarcaId = Input.Marca.Nombre
            };
            return Equipo;

        }
    }
}