using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace alquilerTopografia_master.Models
{
    public class EquipoInputModel
    {
        /*[Required(ErrorMessage = "El ClienteId es Requerido")]
        public string ClienteId { get; set; }*/

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Marca Marca { get; set; }
        public double Valor  { get; set; }
    }

    public class EquipoViewModel : EquipoInputModel
    {
        public EquipoViewModel()
        {
        }
        public EquipoViewModel(Equipo Eq)
        {            
            Id = Eq.Id;
            Nombre = Eq.Nombre;
            Valor = Eq.Valor;
            Marca = new Marca(Eq.MarcaId);
        }        
    }
}

