using torneoPOO_GMERA.MODELS;

Jugador objJugador1 = new Jugador("Jude Bellingham", 23, 10, "centrocampista", "Ingles", 1.86, 75);

Jugador objJugador2 = new Jugador("Harry Kane", 30, 9, "Delantero", "Ingles", 1.88, 86);

Equipo objEquipo1 = new Equipo("England", "Inglaterra", "Thomas Tuchel", 1863, "Wembly Stadium");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);

objEquipo1.ListarPlantilla();

Console.WriteLine("-----------------------------------------------------------------------------------");

Jugador objJugador3 = new Jugador("Erling Haalland", 25, 9, "Medio Campo", "Noruego", 1.95, 88);


Jugador objJugador4 = new Jugador("Alexander Sorloth", 25, 12, "Delantero", "Noruego", 1.95, 90);


Equipo objEquipo2 = new Equipo("Norway", "Noruega","Stale Solbakken", 1902, "Wembly Stadium");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);

objEquipo2.ListarPlantilla();

Console.WriteLine("-----------------------------------------------------------------------------------");

Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "Atlanta", "Michael Oliver",
    71000, "Cuartos de final");
objPartido1.MostrarResumen();