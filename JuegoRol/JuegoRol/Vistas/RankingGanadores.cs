using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace JuegoRol.Vistas
{
    public partial class RankingGanadores : Form
    {
        public RankingGanadores()
        {
            InitializeComponent();
            leerJson();
        }

        private void leerJson()
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

            if(listaGanadores.Count < 10)
            {
                for (int i = listaGanadores.Count; i < 10; i++)
                {
                    Ganador ganadorVacio = new Ganador();
                    ganadorVacio.Nombre = "-";
                    ganadorVacio.Puntos = 0;
                    listaGanadores.Add(ganadorVacio);
                }
            }

            label1.Text = listaGanadores[0].Nombre;
            puntos1.Text = listaGanadores[0].Puntos.ToString();

            label2.Text = listaGanadores[1].Nombre;
            puntos2.Text = listaGanadores[1].Puntos.ToString();

            label3.Text = listaGanadores[2].Nombre;
            puntos3.Text = listaGanadores[2].Puntos.ToString();

            label4.Text = listaGanadores[3].Nombre;
            puntos4.Text = listaGanadores[3].Puntos.ToString();

            label5.Text = listaGanadores[4].Nombre;
            puntos5.Text = listaGanadores[4].Puntos.ToString();

            label6.Text = listaGanadores[5].Nombre;
            puntos6.Text = listaGanadores[5].Puntos.ToString();

            label7.Text = listaGanadores[6].Nombre;
            puntos7.Text = listaGanadores[6].Puntos.ToString();

            label8.Text = listaGanadores[7].Nombre;
            puntos8.Text = listaGanadores[7].Puntos.ToString();

            label9.Text = listaGanadores[8].Nombre;
            puntos9.Text = listaGanadores[8].Puntos.ToString();

            label10.Text = listaGanadores[9].Nombre;
            puntos10.Text = listaGanadores[9].Puntos.ToString();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
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
