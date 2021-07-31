using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JuegoRol
{
    public static class ManejadorJason
    {
        public static List<Ganador> leerArchivoGanadores()
        {
            List<Ganador> listaGanadores;
            string rutaArchivo = @"Ganadores.json";

            try
            {
                using (StreamReader leerJason = File.OpenText(rutaArchivo))
                {
                    var Json = leerJason.ReadToEnd();
                    listaGanadores = JsonSerializer.Deserialize<List<Ganador>>(Json);
                }
            }
            catch (FileNotFoundException)
            {
                listaGanadores = new List<Ganador>();
            }

            return listaGanadores;
        }

        public static void guardarGanador(Ganador ganador)
        {
            List<Ganador> listaGanadores = leerArchivoGanadores();

            int i;
            for (i = 0; i < listaGanadores.Count; i++)
            {
                if (listaGanadores[i].Puntos < ganador.Puntos)
                {
                    break;
                }
            }

            listaGanadores.Insert(i, ganador);

            if (listaGanadores.Count > 10)
            {
                listaGanadores.RemoveAt(10);
            }

            FileStream archiboGanadores = new FileStream("Ganadores.json", FileMode.Create);
            StreamWriter escribirGanador = new StreamWriter(archiboGanadores);

            string strJson = JsonSerializer.Serialize(listaGanadores);
            escribirGanador.WriteLine("{0}", strJson);

            escribirGanador.Close();
        }
    }

    public class Ganador
    {
        string nombre;
        int puntos;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
