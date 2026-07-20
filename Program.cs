using torneoPOO_GMERA.Generales;
using torneoPOO_GMERA.MODELS;


int opcion = 0;
Jugador objJugador1 = new Jugador("Jude Bellingham", 23, 10, "centrocampista", "Ingles", 1.86, 75);
Jugador objJugador2 = new Jugador("Harry Kane", 30, 5, "Delantero", "Ingles", 1.88, 86);
Jugador objJugador3 = new Jugador("Erling Haaland", 25, 9, "Delantero", "Noruego", 1.95, 88);
Jugador objJugador4 = new Jugador("Deaclan Rice", 24, 7, "Defensa", "Ingles", 1.93, 75);
Jugador objJugador5 = new Jugador("Patick Berge", 26, 8, "Delantero", "Noruego", 1.97, 87);
Jugador objJugador6 = new Jugador("Orjan Nylan", 28, 23, "Portero", "Noruego", 1.88, 80);
Database.Jugadores.Add(objJugador1);
Database.Jugadores.Add(objJugador2);
Database.Jugadores.Add(objJugador3);
Database.Jugadores.Add(objJugador4);
Database.Jugadores.Add(objJugador5);
Database.Jugadores.Add(objJugador6);
do
{
    Console.Clear();
    Console.WriteLine("****************Bienvenidos a la Copa del Mundo 2026****************");
    Console.WriteLine("Menú de Opciones:");
    Console.WriteLine("1.- Crear Jugadores");
    Console.WriteLine("2.- Listar Jugadores");
    Console.WriteLine("3.- Buscar Jugador");
    Console.WriteLine("4.- Actualizar Jugador");
    Console.WriteLine("5.- Eliminar Jugador");
    Console.WriteLine("6.- Crear Equipos");
    Console.WriteLine("7.- Listar Equipos");
    Console.WriteLine("8.- Buscar Equipo");
    Console.WriteLine("9.- Actualizar Equipos");
    Console.WriteLine("10.- Eliminar Equipos");
    Console.WriteLine("11.- Crear Partidos");
    Console.WriteLine("12.- Listar Partidos");
    Console.WriteLine("13.- Buscar Partido");
    Console.WriteLine("14.- Actualizar Partido");
    Console.WriteLine("15.- Eliminar Partido");
    Console.WriteLine("16.- Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    switch (opcion)
    {
        case 1:
            crearJugador();
            break;
        case 2:
            listarJugadores();
            break;
        case 3:
            BuscarJugador();
            break;
        case 4:
            ActualizarJugador();
            break;
        case 5:
            EliminarJugador();
            break;
        case 6:
            crearEquipo();
            break;
        case 7:
            listarEquipos();
            break;
        case 8:
            buscarEquipo();
            break;
        case 9:
            actualizarEquipo();
            break;
        case 10:
            EliminarEquipo();
            break;
        case 11:
            crearPartido();
            break;
        case 12:
            ListarPartidos();
            break;
        case 13:
            BuscarPartido();
            break;
        case 14:
            ActualizarPartido();
            break;
        case 15:
            ElminarPartido();
            break;
        case 16:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
            break;
    }
} while (opcion != 16);

void ElminarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Partido**********");

    Console.Write("Ingrese el nombre del equipo local: ");
    string nombre = Console.ReadLine();

    Partido objPartido = Database.Partidos.Find(p => p.Local.Nombre.ToUpper() == nombre.ToUpper());

    if (objPartido != null)
    {
        Database.Partidos.Remove(objPartido);
        Console.WriteLine("Partido eliminado.");
    }
    else
    {
        Console.WriteLine("Partido no encontrado.");
    }

    Console.ReadLine();
}

void EliminarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Equipo**********");

    Console.Write("Ingrese el nombre del equipo a eliminar: ");
    string nombreIngresado = Console.ReadLine();

    Equipo objEquipo = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombreIngresado.ToUpper());

    if (objEquipo != null)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Nombre: {objEquipo.Nombre}");
        Console.WriteLine($"Ciudad: {objEquipo.Ciudad}");
        Console.WriteLine($"Entrenador: {objEquipo.Entrenador}");
        Console.WriteLine("-----------------------------------");

        Console.Write($"¿Está seguro de que desea eliminar el equipo {objEquipo.Nombre}? S/N: ");
        if (Console.ReadLine().ToUpper() == "S")
        {
            Database.Equipos.Remove(objEquipo);
            Console.WriteLine("Equipo eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Operación cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Equipo no encontrado.");
    }

    Console.ReadLine();
}

void ActualizarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Partido**********");

    Console.Write("Ingrese el nombre del equipo local: ");
    string nombre = Console.ReadLine();

    Partido objPartido = Database.Partidos.Find(p => p.Local.Nombre.ToUpper() == nombre.ToUpper());

    if (objPartido != null)
    {
        Console.Write("Nuevo lugar: ");
        objPartido.Lugar = Console.ReadLine();

        Console.Write("Nuevo árbitro: ");
        objPartido.Arbitro = Console.ReadLine();

        Console.Write("Nueva capacidad: ");
        objPartido.CapacidadEstadio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nuevo campeonato: ");
        objPartido.Campeonato = Console.ReadLine();

        Console.WriteLine("Partido actualizado.");
    }
    else
    {
        Console.WriteLine("Partido no encontrado.");
    }

    Console.ReadLine();
}

void BuscarPartido()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Partido**********");
    Console.Write("Ingrese el nombre del equipo local: ");
    string nombre = Console.ReadLine();
    Partido objPartido = Database.Partidos.Find(p => p.Local.Nombre.ToUpper() == nombre.ToUpper());
    if (objPartido != null)
    {
        Console.WriteLine($"Local: {objPartido.Local.Nombre}");
        Console.WriteLine($"Visitante: {objPartido.Visitante.Nombre}");
        Console.WriteLine($"Lugar: {objPartido.Lugar}");
        Console.WriteLine($"Árbitro: {objPartido.Arbitro}");
        Console.WriteLine($"Campeonato: {objPartido.Campeonato}");
    }
    else
    {
        Console.WriteLine("Partido no encontrado.");
    }

    Console.ReadLine();
}

void ListarPartidos()
{
        Console.Clear();
        Console.WriteLine("**********Lista de Partidos**********");
        foreach (Partido partido in Database.Partidos)
        {
            Console.WriteLine($"Local: {partido.Local.Nombre}");
            Console.WriteLine($"Visitante: {partido.Visitante.Nombre}");
            Console.WriteLine($"Fecha: {partido.Fecha}");
            Console.WriteLine($"Lugar: {partido.Lugar}");
            Console.WriteLine($"Árbitro: {partido.Arbitro}");
            Console.WriteLine($"Capacidad: {partido.CapacidadEstadio}");
            Console.WriteLine($"Campeonato: {partido.Campeonato}");
            Console.WriteLine("----------------------------------------");
        }
        Console.ReadLine();
}

void crearPartido()
{
    Console.Clear();
    Console.WriteLine("**********Crear Partido**********");
    Console.Write("Ingrese el nombre del equipo local: ");
    string nombreLocal = Console.ReadLine();
    Equipo local = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombreLocal.ToUpper());
    if (local == null)
    {
        Console.WriteLine("Equipo local no encontrado.");
        Console.ReadLine();
        return;
    }

    Console.Write("Ingrese el nombre del equipo visitante: ");
    string nombreVisitante = Console.ReadLine();
    Equipo visitante = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombreVisitante.ToUpper());
    if (visitante == null)
    {
        Console.WriteLine("Equipo visitante no encontrado.");
        Console.ReadLine();
        return;
    }
    Console.Write("Ingrese el lugar: ");
    string lugar = Console.ReadLine();
    Console.Write("Ingrese el árbitro: ");
    string arbitro = Console.ReadLine();
    Console.Write("Ingrese la capacidad del estadio: ");
    int capacidad = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ingrese el campeonato: ");
    string campeonato = Console.ReadLine();
    Partido objPartido = new Partido(local, visitante, DateTime.Now, lugar, arbitro, capacidad, campeonato);
    Database.Partidos.Add(objPartido);
    Console.WriteLine("Partido creado exitosamente.");
    Console.ReadLine();
}

void actualizarEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Actualizar Equipo**********");

    Console.Write("Ingrese el nombre del equipo a actualizar: ");
    string nombreIngresado = Console.ReadLine();
    Equipo objEquipo = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombreIngresado.ToUpper());

    if (objEquipo != null)
    {
        Console.WriteLine("-----------------------------------");
        objEquipo.Imprimir();
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Ingrese los nuevos datos:");

        Console.Write("Nombre: ");
        objEquipo.Nombre = Console.ReadLine();

        Console.Write("Ciudad: ");
        objEquipo.Ciudad = Console.ReadLine();

        Console.Write("Entrenador: ");
        objEquipo.Entrenador = Console.ReadLine();

        Console.Write("Año de Fundación: ");
        objEquipo.AnioFundacion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Estadio: ");
        objEquipo.Estadio = Console.ReadLine();

        Console.WriteLine("Equipo actualizado exitosamente.");
    }
    else
    {
        Console.WriteLine("Equipo no encontrado.");
    }

    Console.ReadLine();
}

void crearEquipo()
{
    Console.Clear();
    Console.WriteLine("**********Crear Equipo**********");
    Console.WriteLine("Ingrese el nombre del equipo: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la ciudad del equipo: ");
    string ciudad = Console.ReadLine();
    Console.WriteLine("Ingrese el entrenador del equipo: ");
    string entrenador = Console.ReadLine();
    Console.WriteLine("Ingrese el año de fundación: ");
    int anioFundacion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre del estadio del equipo: ");
    string estadio = Console.ReadLine();

    Equipo objEquipo = new Equipo(nombre, ciudad, entrenador, anioFundacion, estadio);
    Console.WriteLine("Equipo creado exitosamente.");
    string respuesta = "";
    do
    {
        Console.WriteLine("¿Desea Ingresar Jugadores? S/N");
        respuesta = Console.ReadLine();
        if (respuesta.ToUpper() == "S")
        {
            Console.WriteLine("Ingrese el nombre del jugador a fichar");
            string nombreIngresado = Console.ReadLine();
            Jugador objJugador = Database.Jugadores.Find(x => x.Nombre == nombreIngresado);
            if (objJugador != null)
            {
                objEquipo.AgregarJugador(objJugador);
                objJugador.Fichar(objEquipo);
                
            }
            else
            {
                Console.WriteLine("Jugador no encontrado.");
            }
        }

    } while (respuesta == "S");
    Database.Equipos.Add(objEquipo);
    Console.ReadLine();
}

void buscarEquipo()
{
    Console.Clear();

    Console.WriteLine("**********Buscar Equipo**********");

    Console.Write("Ingrese el nombre del equipo: ");
    string nombre = Console.ReadLine();

    Equipo objEquipo = Database.Equipos.Find(e => e.Nombre.ToUpper() == nombre.ToUpper());

    if (objEquipo != null)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Nombre: {objEquipo.Nombre}");
        Console.WriteLine($"Ciudad: {objEquipo.Ciudad}");
        Console.WriteLine($"Entrenador: {objEquipo.Entrenador}");
        Console.WriteLine($"Año Fundación: {objEquipo.AnioFundacion}");
        Console.WriteLine($"Estadio: {objEquipo.Estadio}");
    }
    else
    {
        Console.WriteLine("Equipo no encontrado.");
    }

    Console.ReadLine();
}

void listarEquipos()
{
    Console.Clear();
    Console.WriteLine("**********Equipos**********");

    foreach (Equipo equipo in Database.Equipos)
    {
        Console.WriteLine($"Nombre: {equipo.Nombre}");
        Console.WriteLine($"Ciudad: {equipo.Ciudad}");
        Console.WriteLine($"Entrenador: {equipo.Entrenador}");
        Console.WriteLine($"Año Fundación: {equipo.AnioFundacion}");
        Console.WriteLine($"Estadio: {equipo.Estadio}");
        Console.WriteLine("---------------------------------------");
    }

    Console.ReadLine();
}

void EliminarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Jugador**********");
    Console.WriteLine("Ingrese el numero del jugador a buscar: ");
    string nombreIngresado = Console.ReadLine();
    Jugador objJugador = Database.Jugadores.Find(x => x.Nombre == nombreIngresado);
    if (objJugador != null)
    {
        {
            Console.WriteLine("-----------------------------------");
            objJugador.Imprimir();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"¿Está seguro de que desea eliminar a este jugador {objJugador.Nombre} ? S/N:");
            if (Console.ReadLine().ToUpper() == "S")
            {
                Database.Jugadores.Remove(objJugador);
                Console.WriteLine("Jugador eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
        }
 

    }

}

void ActualizarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Jugador**********");
    Console.WriteLine("Ingrese el numero del jugador a buscar: ");
    string nombreIngresado = Console.ReadLine();
    Jugador objJugador = Database.Jugadores.Find(x => x.Nombre == nombreIngresado);
    if (objJugador != null)
    {
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"¿Está seguro de que desea eliminar al jugador {objJugador.Nombre} ? S/N:");
        if (Console.ReadLine().ToUpper() == "S")
        {
            Database.Jugadores.Remove(objJugador);
            Console.WriteLine("Jugador eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Operación cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Jugador no encontrado.");
    }
    Console.ReadLine();
}
    

void BuscarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Buscar Jugador**********");
    Console.WriteLine("Ingrese el numero del jugador a buscar: ");
    string nombreIngresado = Console.ReadLine();
    Jugador objJugador = Database.Jugadores.Find(x => x.Nombre == nombreIngresado);
    if (objJugador != null)
    {
        Console.WriteLine("Jugador encontrado:");
        Console.WriteLine("-----------------------------------");
        objJugador.Imprimir();
    }
    else
    {
        Console.WriteLine("Jugador no encontrado.");
    }
    Console.ReadLine();

}

void listarJugadores()
{
    Console.Clear();
    Console.WriteLine("**********Jugadores Creados**********");
    foreach (Jugador jugador in Database.Jugadores)
    {
        jugador.Imprimir();
        Console.WriteLine("--------------------------------------");
    }
    Console.ReadLine();
}

void crearJugador()
{
    Console.Clear();
    Console.WriteLine("**********Crear Jugador**********");
    Console.WriteLine("Ingrese el nombre del jugador: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la edad del jugador: ");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el número del jugador: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la posición del jugador: ");
    string posicion = Console.ReadLine();
    Console.WriteLine("Ingrese la nacionalidad del jugador: ");
    string nacionalidad = Console.ReadLine();
    Console.WriteLine("Ingrese la estatura del jugador: ");
    double estatura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el peso del jugador: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Jugador objJugador = new Jugador(nombre, edad, numero, posicion, nacionalidad, estatura, peso);
    Database.Jugadores.Add(objJugador);
    Console.WriteLine("Jugador creado exitosamente.");
    Console.ReadLine();
}





/*Jugador objJugador1 = new Jugador("Jude Bellingham", 23, 10, "centrocampista", "Ingles", 1.86, 75);

Jugador objJugador2 = new Jugador("Harry Kane", 30, 9, "Delantero", "Ingles", 1.88, 86);

Equipo objEquipo1 = new Equipo("England", "Inglaterra", "Thomas Tuchel", 1863, "Wembly Stadium");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);

objEquipo1.ListarPlantilla();

Console.WriteLine("-----------------------------------------------------------------------------------");

Jugador objJugador3 = new Jugador("Erling Haalland", 25, 9, "Delantero", "Noruego", 1.95, 88);


Jugador objJugador4 = new Jugador("Alexander Sorloth", 25, 12, "Delantero", "Noruego", 1.95, 90);


Equipo objEquipo2 = new Equipo("Norway", "Noruega","Stale Solbakken", 1902, "Wembly Stadium");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);

objEquipo2.ListarPlantilla();

Console.WriteLine("-----------------------------------------------------------------------------------");

Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "London", "Michael Oliver",
    71000, "Cuartos de final");
objPartido1.MostrarResumen();*/
