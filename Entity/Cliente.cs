using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Cliente
    {
        [Key]
        public long ClienteId { get; set; }
        public string TipoId { get; set; }
        public string NCliente { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public List<Alquiler> Alquilers { get; } = new List<Alquiler>();

    }
}