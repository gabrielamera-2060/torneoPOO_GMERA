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

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public double Estatura { get => estatura; set => estatura = value; }
        public double Peso { get => peso; set => peso = value; }


        //Constructor
        public Jugador(string nombre, int edad, int numero, string posicion, string nacionalidad, double estatura, double peso)
        {
            if (edad < 18)
            {
                throw new Exception("El jugador debe ser mayor de edad.");
            }

            if (numero <= 0 || numero >= 100)
            {
                throw new Exception("El número de camiseta no es valido.");
            }

            if (string.IsNullOrWhiteSpace(nacionalidad))
            {
                throw new Exception("La nacionalidad es obligatoria.");
            }

            if (estatura <= 0)
            {
                throw new Exception("La estatura debe ser mayor que cero.");
            }

            if (peso <= 0)
            {
                throw new Exception("El peso debe ser mayor que cero.");
            }

            this.Nombre = nombre;
            this.Edad = edad;
            this.Numero = numero;
            this.Posicion = posicion;
            this.Nacionalidad = nacionalidad;
            this.Estatura = estatura;
            this.Peso = peso;
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
    }
}
