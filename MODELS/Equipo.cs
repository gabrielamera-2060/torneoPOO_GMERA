using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;
using torneoPOO_GMERA.MODELS;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace torneoPOO_GMERA.MODELS
{
    public class Equipo
    {
        private string nombre;
        private string ciudad;
        private List<Jugador> jugadores;
        private string entrenador;
        private int anioFundacion;
        private string estadio;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Entrenador 
        { 
            get => entrenador; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El entrenador es obligatorio.");
                }
                entrenador = value;
            }
        }
        public int AnioFundacion 
        { 
            get => anioFundacion; 
            set
            {
                if (value < 1800 || value > DateTime.Now.Year)
                {
                    throw new Exception("El año de fundación no es válido.");
                }
                anioFundacion = value;
            }
        }
        public string Estadio 
        { 
            get => estadio; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El estadio es obligatorio.");
                }
                estadio = value;
            }
        }

        public Equipo(string? nombre, string? ciudad, string? entrenador, int anioFundacion, string estadio)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.entrenador = entrenador;
            this.anioFundacion = anioFundacion;
            this.jugadores = new List<Jugador>();
            this.estadio = estadio;
        }

        public void AgregarJugador(Jugador objJugador)
        {
            this.Jugadores.Add(objJugador);
            Console.WriteLine($"Jugador{objJugador.Nombre} agregador correctamemte");
        }

        public void ListarPlantilla()
        {
            Console.WriteLine($"La lista de jugadores del equipo de {this.Nombre} del pais de {this.Ciudad} es:");
            foreach (Jugador objJugador in Jugadores)
            {
                objJugador.Imprimir();
                Console.WriteLine("_______________________________________");
            }
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre del equipo: {this.Nombre}");
            Console.WriteLine($"Ciudad del equipo: {this.Ciudad}");
            Console.WriteLine($"Entrenador del equipo: {this.entrenador}");
            ListarPlantilla();
        }
    }
}
   
