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
        private readonly AlquilerService _alquilerService;
        public AlquilerController(AlquilerContext context)
        {
            _alquilerService = new AlquilerService(context);
        }

        // GET: api/Alquiler
        [HttpGet]
        public IEnumerable<AlquilerViewModel> Gets()
        {
            var alquilers = _alquilerService.ConsultarTodosAlquiler().Select(p => new AlquilerViewModel());
            return alquilers;
        }

        // POST: api/Alquiler
        [HttpPost]
        
        //
        private Alquiler MapearAlquiler(AlquilerInputModel alquilerInput)
        {
            var alquiler = new Alquiler
            {
                AlquilerId = alquilerInput.AlquilerId,
                EquipoId = alquilerInput.EquipoId,
                TiempoAlquiler = alquilerInput.TiempoAlquiler
            };
            return alquiler;

        }
    }
}