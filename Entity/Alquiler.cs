using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{

    public class Alquiler
    {

        [Key]
        public int AlquilerId { get; set; }

        public int TiempoAlquiler { get; set; }

        public double Valor { get; set; }
         
        public void ValorAlquiler()
        {}
       /*     if (TiempoAlquiler.Equals("Estacion") && TiempoAlquiler.Equals("Dia"))  <!-cambiar ->
            {
                Valor = 100.000;
            }
            else if (NEquipo.Equals("Estacion") && TiempoAlquiler.Equals("Mes"))
            {
                Valor = 1500.000;
            }
            else if (NEquipo.Equals("Estacion") && TiempoAlquiler.Equals("Trimestre"))
            {
                Valor = 3900.000;
            }
            else if (NEquipo.Equals("Estacion") && TiempoAlquiler.Equals("Semestre"))
            {
                Valor = 3900.000;
            }
            else if (NEquipo.Equals("Nivel Precision") && TiempoAlquiler.Equals("Dia"))
            {
                Valor = 25.000;
            }
            else if (NEquipo.Equals("Nivel Precision") && TiempoAlquiler.Equals("Mes"))
            {
                Valor = 450.000;
            }
            else if (NEquipo.Equals("Nivel Precision") && TiempoAlquiler.Equals("Trimestre"))
            {
                Valor = 1140.000;
            }
            else if (NEquipo.Equals("Nivel Precision") && TiempoAlquiler.Equals("Semestre"))
            {
                Valor = 2300.000;
            }
            else if (NEquipo.Equals("GPS Navegador") && TiempoAlquiler.Equals("Dia"))
            {
                Valor = 20.000;
            }
            else if (NEquipo.Equals("GPS Navegador") && TiempoAlquiler.Equals("Mes"))
            {
                Valor = 400.000;
            }
            else if (NEquipo.Equals("GPS Navegador") && TiempoAlquiler.Equals("Trimestre"))
            {
                Valor = 1050.000;
            }
            else if (NEquipo.Equals("GPS Navegador") && TiempoAlquiler.Equals("Semestre"))
            {
                Valor = 2000.000;
            }
            else if (NEquipo.Equals("GPS Submétrico") && TiempoAlquiler.Equals("Dia"))
            {
                Valor = 70.000;
            }
            else if (NEquipo.Equals("GPS Submétrico") && TiempoAlquiler.Equals("Mes"))
            {
                Valor = 1500.000;
            }
            else if (NEquipo.Equals("GPS Submétrico") && TiempoAlquiler.Equals("Trimestre"))
            {
                Valor = 3600.000;
            }
            else if (NEquipo.Equals("GPS Submétrico") && TiempoAlquiler.Equals("Semestre"))
            {
                Valor = 5500.000;
            }
            else if (NEquipo.Equals("RTK GPS Doble Frecuencia") && TiempoAlquiler.Equals("Dia"))
            {
                Valor = 300.000;
            }
            else if (NEquipo.Equals("RTK GPS Doble Frecuencia") && TiempoAlquiler.Equals("Mes"))
            {
                Valor = 7000.000;
            }
            else if (NEquipo.Equals("RTK GPS Doble Frecuencia") && TiempoAlquiler.Equals("Trimestre"))
            {
                Valor = 16000.000;
            }
            else
            {
                Valor = 24000.000;
            }
        }
 */
        public int ClienteId {get; set;}
        
        public Cliente Cliente {get;}

        public int EquipoId {get; set;}
        
        public Equipo Equipo {get;}

    }
}