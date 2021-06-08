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
        public FormCrearPersonaje()
        {
            InitializeComponent();
            tipoPersonaje.Items.Add("Humano");
            tipoPersonaje.Items.Add("Elfo");
            tipoPersonaje.Items.Add("Enano");
            tipoPersonaje.Items.Add("Orco");
            tipoPersonaje.Items.Add("Hobbit");
        }

        private void btnPersAleatorio_Click(object sender, EventArgs e)
        {
            CreadorPersonajePrueba nuevoCreador = new CreadorPersonajePrueba();
            Personajes nuevoPersonaje = nuevoCreador.GenerarPersonaje();

            Personaje_Nuevo ventana = new Personaje_Nuevo(nuevoPersonaje);
            ventana.Show();
        }
    }
}
