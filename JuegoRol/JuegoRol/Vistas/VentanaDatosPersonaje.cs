using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace JuegoRol
{
    public partial class VentanaDatosPersonaje : Form
    {
        private List<Personaje> listaParticipantes;
        public VentanaDatosPersonaje(List<Personaje> personajes)
        {
            InitializeComponent();
            this.listaParticipantes = personajes;
            inicializarComboBox();                 
        }

        private void inicializarComboBox()
        {
            foreach (Personaje personaje in listaParticipantes)
            {
                comboBoxPersonajes.Items.Add(personaje.Nombre);
            }

            comboBoxPersonajes.SelectedIndex = 0;
        }

        private void comboBoxPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxPersonajes.SelectedIndex;
            inicializarPersonaje(listaParticipantes.ElementAt(i));           
            
        }

        private void inicializarPersonaje(Personaje participante)
        {
            label1.Text = Convert.ToString(participante.Tipo);
            label2.Text = participante.Nombre;
            label3.Text = participante.Apodo;
            DateTime fechaSola = participante.FechaNacimiento.Date;
            label4.Text = fechaSola.ToString("d");
            label5.Text = Convert.ToString(participante.Edad);
            label6.Text = Convert.ToString(participante.Salud);

            label12.Text = Convert.ToString(participante.Velocidad);
            label13.Text = Convert.ToString(participante.Destreza);
            label14.Text = Convert.ToString(participante.Fuerza);
            label15.Text = Convert.ToString(participante.Nivel);
            label16.Text = Convert.ToString(participante.Armadura);
        }

        private void btnIrBatalla_Click(object sender, EventArgs e)
        {
            VentanaBatalla ventanaNuevaBatalla = new VentanaBatalla(listaParticipantes);
            ventanaNuevaBatalla.Show();
            Close();
        }

        private void btnGuardarListaPersj_Click(object sender, EventArgs e)
        {
            guardarArchivoCSV();
            guardarArchivoJson();
            MessageBox.Show("Los Jugadores se guardaron con exito!!!", "Guardar Lista de Personajes");
        }

        private void guardarArchivoCSV()
        {
            FileStream jugadores = new FileStream("ListaJugadores.csv", FileMode.Create);
            StreamWriter escribirJugadore = new StreamWriter(jugadores);

            foreach (Personaje personaje in listaParticipantes)
            {
                escribirJugadore.WriteLine("{0};{1};{2}", personaje.Nombre, personaje.Tipo, personaje.Salud);
            }
            escribirJugadore.Close();
        }

        private void guardarArchivoJson()
        {
            
            FileStream jugadores = new FileStream("ListaJugadores.Json", FileMode.Create);
            StreamWriter escribirJugadore = new StreamWriter(jugadores);

            foreach (Personaje personaje in listaParticipantes)
            {
                string strJson = JsonSerializer.Serialize(personaje);
                escribirJugadore.WriteLine("{0}", strJson);
            }
            escribirJugadore.Close();
        }
    }
}
