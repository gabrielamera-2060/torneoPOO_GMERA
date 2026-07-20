using torneoPOO_GMERA.Generales;
using torneoPOO_GMERA.MODELS;


int opcion = 0;
Jugador objJugador1 = new Jugador("Jude Bellingham", 23, 10, "centrocampista", "Ingles", 1.86, 75);
Database.Jugadores.Add(objJugador1);
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
        default:
            Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
            break;
    }
} while (opcion != 8);

void buscarEquipo()
{
    Console.Clear();
}

void listarEquipos()
{
    Console.Clear();
}

void crearEquipo()
{
    Console.Clear();
}

void EliminarJugador()
{
    Console.Clear();
    Console.WriteLine("**********Eliminar Jugador**********");
    Console.WriteLine("Ingrese el numero del jugador a buscar: ");
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());
    Jugador objJugador = Database.Jugadores.Find(j => j.Numero == numeroIngresado);
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
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());
    Jugador objJugador = Database.Jugadores.Find(j => j.Numero == numeroIngresado);
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
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());
    Jugador objJugador = Database.Jugadores.Find(j => j.Numero == numeroIngresado);
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
