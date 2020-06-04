using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Cliente
    {
        [Key]
        public string Id { get; set; }
        public string TipoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

    }
}