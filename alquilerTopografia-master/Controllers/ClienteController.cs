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
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _cltService;
        public ClienteController(AlquilerContext context)
        {
            _cltService = new ClienteService(context);
        }

        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<ClienteViewModel> Gets()
        {
            var clientes = _cltService.ConsultarTodosCliente().Select(p => new ClienteViewModel(p));
            return clientes;
        }

        // POST: api/Cliente
        [HttpPost]
        public ActionResult<ClienteViewModel> Post(ClienteInputModel cltInput)
        {
            Cliente clt = MapearCliente(cltInput);
            var response = _cltService.Guardar(clt);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Cliente);
        }

        
        //
        private Cliente MapearCliente(ClienteInputModel Input)
        {
            var cliente = new Cliente
            {
                Id = Input.Id,
                Nombre = Input.Nombre,
                TipoId = Input.TipoId,
                Direccion = Input.Direccion,
                Email = Input.Email,
                Telefono = Input.Telefono
            };

            return cliente;
        }
    }
}