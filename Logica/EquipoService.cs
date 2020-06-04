using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class EquipoService 
    {
        private readonly AlquilerContext _context;

        public EquipoService(AlquilerContext context)
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

        public List<Equipo> ConsultarTodosEquipo()
        {
            List<Equipo> equilers = _context.Equipos.ToList();
            return equilers;
        }

         public GuardarResponse Guardar(Equipo eq)
        {
            var Alq = _context.Equipos.Find(eq.Id);
            if(Alq != null){
                return new GuardarResponse("Error al guardar");
            }
            else{                
                _context.Equipos.Add(eq);
                _context.SaveChanges();
                return new GuardarResponse(eq);
            }

        }

        public Cliente BuscarxNombreCliente (string NCliente)
        {
            Cliente clientes = _context.Clientes.Find(NCliente);
            return clientes;
        }

        public class GuardarResponse
        {
            public GuardarResponse(Equipo eq)
            {
                Error = false;
                Equipo = eq;
            }
            public GuardarResponse(string mensaje)
            {      
                Error = true;
                Mensaje = mensaje;
            }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Equipo Equipo { get; set; }
        }

    }
}