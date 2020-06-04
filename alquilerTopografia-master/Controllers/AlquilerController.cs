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


namespace alquilerTopografia_master.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {
        private readonly AlquilerService _alqService;
        private readonly ClienteService _clService;
        private readonly EquipoService _eqService;


        public AlquilerController(AlquilerContext context)
        {
            _alqService = new AlquilerService(context);
        }

        // GET: api/Alquiler
        [HttpGet]
        public IEnumerable<AlquilerViewModel> Gets()
        {
            var alquilers = _alqService.ConsultarTodosAlquiler().Select(p => new AlquilerViewModel());
            return alquilers;
        }

        // POST: api/Alquiler
        [HttpPost]
        public ActionResult<AlquilerViewModel> Post(AlquilerInputModel alqInput)
        {
            Alquiler alq = MapearAlquiler(alqInput);
            var response = _alqService.Guardar(alq);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Alquiler);
        }

        
        //
        private Alquiler MapearAlquiler(AlquilerInputModel Input)
        {
            var alquiler = new Alquiler
            {
                Id = Input.Id,
                Inicio = Input.Inicio,
                Final = Input.Final,
                Tiempo = (Input.Inicio - Input.Final).TotalDays,
                Valor = Input.CalcularValor(),
                ClienteId =Input.Cliente.Id
            };
            
            return alquiler;

        }
    }
}