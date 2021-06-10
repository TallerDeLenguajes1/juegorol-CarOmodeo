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
    public partial class FormCrearPersonaje : Form
    {
        List<Personaje> personajes = new List<Personaje>();
        int cantidadParticipantes = 8;
        public FormCrearPersonaje()
        {
            InitializeComponent();
            tipoPersonaje.Items.Add("Humano");
            tipoPersonaje.Items.Add("Elfo");
            tipoPersonaje.Items.Add("Enano");
            tipoPersonaje.Items.Add("Orco");
            tipoPersonaje.Items.Add("Hobbit");
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void btnPersAleatorio_Click(object sender, EventArgs e)
        {
            Personaje nuevoPersonaje = CreadorPersonajePrueba.GenerarPersonaje();
            personajes.Add(nuevoPersonaje);            
        }

        private void btnMostrarDatosPersonajes_Click(object sender, EventArgs e)
        {
            do
            {
                Personaje nuevoPersonaje = CreadorPersonajePrueba.GenerarPersonaje();
                personajes.Add(nuevoPersonaje);
            } while (personajes.Count != cantidadParticipantes);

            VentanaDatosPersonaje ventanaDatos = new VentanaDatosPersonaje(personajes);
            ventanaDatos.Show();
        }
    }
}
