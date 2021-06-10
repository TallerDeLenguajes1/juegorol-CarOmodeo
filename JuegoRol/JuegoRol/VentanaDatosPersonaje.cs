using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class VentanaDatosPersonaje : Form
    {
        public List<Personaje> listaParticipantes;
        public VentanaDatosPersonaje(List<Personaje> personajes)
        {
            InitializeComponent();

            this.listaParticipantes = personajes;

            foreach(Personaje personaje in personajes)
            {
                comboBoxPersonajes.Items.Add(personaje.Nombre);
            }

            comboBoxPersonajes.SelectedIndex = 0; 
            
        }

        private void comboBoxPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxPersonajes.SelectedIndex;
            Personaje participante = listaParticipantes.ElementAt(i);
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
    }
}
