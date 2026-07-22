using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace torneoPOO_GMERA.Generales
{
    public static class ArchivoJson
    {
        private static readonly JsonSerializerOptions Opciones = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static List<T> Cargar<T>(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                return new List<T>();
            }
            string contenido = File.ReadAllText(rutaArchivo);
            return JsonSerializer.Deserialize<List<T>>(contenido, Opciones) ?? new List<T>();
        }

        public static void Guardar<T>(string rutaArchivo, List<T> lista)
        {
            string contenido = JsonSerializer.Serialize(lista, Opciones);
            File.WriteAllText(rutaArchivo, contenido);
        }

    }
}