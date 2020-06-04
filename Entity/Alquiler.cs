using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{

    public class Alquiler
    {

        [Key]
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public double Tiempo { get; set; }
        public double Valor { get; set; }         
        public string ClienteId {get; set;}        
        public Cliente Cliente {get;}

    }
}