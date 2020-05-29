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

        public Cliente BuscarxNombreCliente (string NCliente)
        {
            Cliente clientes = _context.Clientes.Find(NCliente);
            return clientes;
        }
    }
}