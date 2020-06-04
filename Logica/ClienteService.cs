using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class ClienteService 
    {
        private readonly AlquilerContext _context;

        public ClienteService(AlquilerContext context)
        {
            _context = context;
        }

        public List<Cliente> ConsultarTodosClientes()
        {
            List<Cliente> clientes = _context.Clientes.ToList();
            return clientes;
        }

        public List<Equipo> ConsultarTodosEquipos()
        {
            List<Equipo> equipos = _context.Equipos.ToList();
            return equipos;
        }

        public List<Cliente> ConsultarTodosCliente()
        {
            List<Cliente> alquilers = _context.Clientes.ToList();
            return alquilers;
        }

         public GuardarResponse Guardar(Cliente alq)
        {
            var Alq = _context.Clientes.Find(alq.Id);
            if(Alq != null){
                return new GuardarResponse("Error al guardar");
            }
            else{                
                _context.Clientes.Add(alq);
                _context.SaveChanges();
                return new GuardarResponse(alq);
            }

        }

        public Cliente BuscarxNombreCliente (string NCliente)
        {
            Cliente clientes = _context.Clientes.Find(NCliente);
            return clientes;
        }

        public class GuardarResponse
        {
            public GuardarResponse(Cliente alq)
            {
                Error = false;
                Cliente = alq;
            }
            public GuardarResponse(string mensaje)
            {      
                Error = true;
                Mensaje = mensaje;
            }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Cliente Cliente { get; set; }
        }

    }
}