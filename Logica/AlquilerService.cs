using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class AlquilerService 
    {
        private readonly AlquilerContext _context;

        public AlquilerService(AlquilerContext context)
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

        public List<Alquiler> ConsultarTodosAlquiler()
        {
            List<Alquiler> alquilers = _context.Alquilers.ToList();
            return alquilers;
        }

         public GuardarResponse Guardar(Alquiler alq)
        {
            var Alq = _context.Alquilers.Find(alq.Id);
            if(Alq != null){
                return new GuardarResponse("Error al guardar");
            }
            else{                
                _context.Alquilers.Add(alq);
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
            public GuardarResponse(Alquiler alq)
            {
                Error = false;
                Alquiler = alq;
            }
            public GuardarResponse(string mensaje)
            {      
                Error = true;
                Mensaje = mensaje;
            }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Alquiler Alquiler { get; set; }
        }

    }
}