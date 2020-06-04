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
    public class MarcaController : ControllerBase
    {
        private readonly MarcaService _eqService;
        public MarcaController(AlquilerContext context)
        {
            _eqService = new MarcaService(context);
        }

        // GET: api/Marca
        [HttpGet]
        public IEnumerable<MarcaViewModel> Gets()
        {
            var equilers = _eqService.ConsultarTodosMarca().Select(p => new MarcaViewModel(p));
            return equilers;
        }

        // POST: api/Marca
        [HttpPost]
        public ActionResult<MarcaViewModel> Post(MarcaInputModel eqInput)
        {
            Marca eq = MapearMarca(eqInput);
            var response = _eqService.Guardar(eq);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Marca);
        }

        
        //
        private Marca MapearMarca(MarcaInputModel Input)
        {
            var Marca = new Marca
            {
                Nombre = Input.Nombre,
            };

            return Marca;

        }
    }
}