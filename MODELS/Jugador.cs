using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace torneoPOO_GMERA.MODELS
{
    public class Jugador
    {
        //ATRIBUTOS O CARACTERISTICAS
        private string nombre;
        private int edad;
        private int numero;
        private string posicion;
        private string nacionalidad;
        private double estatura;
        private double peso;
        private string fichado;
        private Equipo equipo_actual;

        public string Nombre{ get => nombre; set => nombre = value; }
        public int Edad
        {
            get => edad;
            set
            {
                if (!EsMayorEdad(value))
                {
                    throw new Exception("El jugador debe ser mayor de edad");
                }
                edad = value;
            }

        }

        public int Numero
        {
            get => numero;
            set
            {
                if (!EsNumeroValido(value))
                {
                    throw new Exception(" El número de la camiseta no es válido");
                }
                numero = value;
            }
        }
       
        public string Posicion { get => posicion; set => posicion = value; }
        public string Nacionalidad 
        { 
            get => nacionalidad;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La nacionalidad es obligatoria.");
                }
                nacionalidad = value;
            }
        }
        public double Estatura
        {
            get => estatura;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La estatura debe ser mayor que cero.");
                }
                estatura = value;
            }
        }

        public double Peso 
        { 
            get => peso; 
            set
            {
                if (value <= 0)
                {
                    throw new Exception("El peso debe ser mayor que cero.");
                }
                peso = value;
            } 
        }
        public string Fichado { get => fichado; }

        //Constructor
        public Jugador(string nombre, int edad, int numero, string posicion, string nacionalidad, double estatura, double peso)
        { 
            this.Nombre = nombre;
            this.Edad = edad;
            this.Numero = numero;
            this.Posicion = posicion;
            this.Nacionalidad = nacionalidad;
            this.Estatura = estatura;
            this.Peso = peso;
            this.fichado = "N";
            this.equipo_actual = null;
        }

        //METODOS, COMPORTAMIENTOS O FUNCIONES
        public void Presentar()
        {
            Console.WriteLine($"Hola soy {this.Nombre} tengo {this.Edad} años y mi número es el {this.Numero}");
        }

        public Boolean EsMayorEdad()
        {
            if (this.Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EsNumeroValido()
        {
            if (this.Numero > 0 && this.Numero < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsMayorEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EsNumeroValido(int numero)
        {
            if (numero > 0 && numero < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine($"nacionalidad: {this.nacionalidad}");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"estatura: {this.estatura}");
            Console.WriteLine($"Número: {this.Numero}");
            Console.WriteLine($"Posición: {this.Posicion}");
            Console.WriteLine($"peso: {this.peso}");
            Console.WriteLine($"Fichado: {this.Fichado}");
        }

        public void Fichar(Equipo objEquipoFichado)
        {
            this.fichado = "S";
            this.equipo_actual = objEquipoFichado;
        }

    }
}
