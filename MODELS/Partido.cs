using System;
using System.Collections.Generic;
using System.Text;

namespace torneoPOO_GMERA.MODELS
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        public void Programar(Equipo local, Equipo visitante, DateTime fecha, string lugar)
        {
            if (local.Nombre == visitante.Nombre)
            {
                Console.WriteLine("El equipo local y el visitante no pueden ser el mismo.");
                return;
            }

            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;

            Console.WriteLine("Partido programado correctamente");
        }

    }
}
