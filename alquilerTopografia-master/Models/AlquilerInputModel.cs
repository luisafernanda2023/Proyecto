using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace alquilerTopografia_master.Models
{
    public class AlquilerInputModel
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public double Tiempo { get; set; }
        public double Valor { get; set; }     
        public Cliente Cliente { get; set; }
        public List<Equipo> Equipos;
        public double CalcularValor(){
            if(Equipos == null)
                return 0;
            var sum = 0.0;
            foreach (var item in Equipos)
            {
                sum+=item.Valor;
            }
            return sum;
        }

    }

    public class AlquilerViewModel : AlquilerInputModel
    {

        public AlquilerViewModel()
        {
        }
        public AlquilerViewModel(Alquiler alq, Cliente cl, List<Equipo> eqs)
        {
            Inicio = alq.Inicio;
            Final = alq.Final;
            Cliente = cl;
            Tiempo = (Inicio - Final).TotalDays;
            Equipos = eqs;
            Valor = Tiempo * CalcularValor(eqs);
        }

        private double CalcularValor(List<Equipo> Eqs){
            if(Eqs == null)
                return 0;
            var sum = 0.0;
            foreach (var item in Eqs)
            {
                sum+=item.Valor;
            }
            return sum;
        }
    }
}

