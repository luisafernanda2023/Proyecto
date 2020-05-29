using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace alquilerTopografia_master.Models
{
    public class AlquilerInputModel
    {
        [Required]
        public string TipoId { get; set; }
        [Required]
        public long ClienteId { get; set; }
        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string NCliente { get; set; }
        [Required(ErrorMessage = "El Telefono es Requerido")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "La Direcciòn es Requerida")]
        public string Direccion { get; set; }
        public int EquipoId { get; set; }
        public string NEquipo { get; set; }
        public int AlquilerId { get; set; }
        public int TiempoAlquiler { get; set; }
    }

    public class AlquilerViewModel : AlquilerInputModel
    {
        public AlquilerViewModel()
        {
        }
        public AlquilerViewModel(Cliente cliente, Alquiler alquiler, Equipo equipo)
        {
            ClienteId = cliente.ClienteId;
            NCliente = cliente.NCliente;
            Telefono = cliente.Telefono;
            Direccion = cliente.Direccion;
            EquipoId = equipo.EquipoId;
            NEquipo = equipo.NEquipo;
            AlquilerId = alquiler.AlquilerId;
            TiempoAlquiler = alquiler.TiempoAlquiler;
            Valor = alquiler.Valor;
        }
        public double Valor { get; set; }
    }
}

