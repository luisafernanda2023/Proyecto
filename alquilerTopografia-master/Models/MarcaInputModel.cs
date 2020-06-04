using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace alquilerTopografia_master.Models
{
    public class MarcaInputModel
    {
        /*[Required(ErrorMessage = "El ClienteId es Requerido")]
        public string ClienteId { get; set; }*/
        public string Nombre { get; set; }
    }

    public class MarcaViewModel : MarcaInputModel
    {
        public MarcaViewModel()
        {
        }
        public MarcaViewModel(Marca Ma)
        {            
            Nombre = Ma.Nombre;
        }        
    }
}

