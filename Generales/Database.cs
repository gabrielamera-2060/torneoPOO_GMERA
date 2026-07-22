using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Text;
using torneoPOO_GMERA.MODELS;

namespace torneoPOO_GMERA.Generales
{
    public static class Database
    {
        private static readonly string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
        private static readonly string rutaArchivoJugadores = Path.Combine(rutaCarpeta, "jugadores.json");
        private static readonly string rutaArchivoEquipos = Path.Combine(rutaCarpeta, "equipo.json");
        private static readonly string rutaArchivoPartidos = Path.Combine(rutaCarpeta, "partidos.json");


        public static List<Jugador> Jugadores { get; set; } = new List<Jugador>();
        public static List<Equipo> Equipos { get; set; } = new List<Equipo>();
        public static List<Partido> Partidos { get; set; } = new List<Partido>();

        public static void


    }
}


