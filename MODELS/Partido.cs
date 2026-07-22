using System;
using System.Collections.Generic;
using System.Text;

namespace torneoPOO_GMERA.MODELS
{
    public class Partido
    {
        private int id;
        private Equipo local;
        private Equipo visitante;
        private DateTime fecha; 
        private string lugar;
        private string arbitro;
        private int capacidadEstadio;
        private string campeonato;

        public Equipo Local { get => local; set => local = value; }
        public Equipo Visitante { get => visitante; set => visitante = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string Arbitro 
        { 
            get => arbitro;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El árbitro es obligatorio.");
                }
                arbitro = value;
            }
        }
        public int CapacidadEstadio 
        { 
            get => capacidadEstadio; 
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La capacidad del estadio debe ser mayor que cero.");
                }
                capacidadEstadio = value;
            }
        }
        public string Campeonato 
        { 
            get => campeonato; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El campeonato es obligatorio.");
                }
                campeonato = value;
            }
        }

        public int Id { get => id; set => id = value; }

        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar, string arbitro, int capacidadEstadio, string campeonato)
        {
            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
            this.Arbitro = arbitro;
            this.CapacidadEstadio = capacidadEstadio;
            this.Campeonato = campeonato;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
        public void Imprimir()
        {
            Console.WriteLine($"Lugar: {this.Lugar}");
            Console.WriteLine($"id: {this.id}");
            Console.WriteLine($"Árbitro: {this.Arbitro}");
            Console.WriteLine($"Capacidad del Estadio: {this.CapacidadEstadio}");
            Console.WriteLine($"Campeonato: {this.Campeonato}");
        }
    }
}
