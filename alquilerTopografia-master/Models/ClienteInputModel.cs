using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace alquilerTopografia_master.Models
{
    public class ClienteInputModel
    {
        /*public long ClienteId { get; set; }
        [Required(ErrorMessage = "El Nombre es Requerido")]*/        
        public string Id { get; set; }
        public string TipoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

    }

    public class ClienteViewModel : ClienteInputModel
    {
        public ClienteViewModel()
        {
        }
        public ClienteViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            TipoId = cliente.TipoId;
            Nombre = cliente.Nombre;
            Telefono = cliente.Telefono;
            Direccion = cliente.Direccion;
            Email = cliente.Email;
            //Valor = alquiler.Valor;
        }
    }
}

