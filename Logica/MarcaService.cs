using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class MarcaService 
    {
        private readonly AlquilerContext _context;

        public MarcaService(AlquilerContext context)
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

        public List<Marca> ConsultarTodosMarca()
        {
            List<Marca> mrcuilers = _context.Marcas.ToList();
            return mrcuilers;
        }

         public GuardarResponse Guardar(Marca mrc)
        {
            var Alq = _context.Marcas.Find(mrc.Nombre);
            if(Alq != null){
                return new GuardarResponse("Error al guardar");
            }
            else{                
                _context.Marcas.Add(mrc);
                _context.SaveChanges();
                return new GuardarResponse(mrc);
            }

        }

        public Cliente BuscarxNombreCliente (string NCliente)
        {
            Cliente clientes = _context.Clientes.Find(NCliente);
            return clientes;
        }

        public class GuardarResponse
        {
            public GuardarResponse(Marca mrc)
            {
                Error = false;
                Marca = mrc;
            }
            public GuardarResponse(string mensaje)
            {      
                Error = true;
                Mensaje = mensaje;
            }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Marca Marca { get; set; }
        }

    }
}