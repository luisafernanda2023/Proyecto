using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Marca
    {
        [Key]
        public string Nombre { get; set; }

        public Marca() { }

        public Marca(string name) { 
            this.Nombre = name;
        }
    }
}