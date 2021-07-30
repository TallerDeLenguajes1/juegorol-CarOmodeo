using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JuegoRol
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> listaPokemones = GetApi();
            Application.Run(new FormCrearPersonaje(listaPokemones));

        }

        private static List<string> GetApi()
        {
            var url = $"https://pokeapi.co/api/v2/pokemon";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            List<string> listaPokemones = new List<string>();

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return listaPokemones;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();

                            Pokemon pokemones = JsonSerializer.Deserialize<Pokemon>(responseBody);

                            foreach (Result pokemon in pokemones.Results)
                            {
                                listaPokemones.Add(pokemon.Name);
                            }

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }

            return listaPokemones;
        }

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Result
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public class Pokemon
        {
            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonPropertyName("next")]
            public string Next { get; set; }

            [JsonPropertyName("previous")]
            public object Previous { get; set; }

            [JsonPropertyName("results")]
            public List<Result> Results { get; set; }
        }
    }
}
