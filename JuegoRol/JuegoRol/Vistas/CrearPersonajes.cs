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
            inicializarComboBox();
            setearDateTimePicker();
        }

        private void inicializarComboBox()
        {
            tipoPersonaje.Items.Add("Humano");
            tipoPersonaje.Items.Add("Orco");
            tipoPersonaje.Items.Add("Elfo");
            tipoPersonaje.Items.Add("Enano");
            tipoPersonaje.Items.Add("Hobbit");
        }
        private void setearDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void btnPersAleatorio_Click(object sender, EventArgs e)
        {
            agregarPersonajeALista(CreadorPersonajePrueba.GenerarPersonaje());
        }

        private void btnMostrarDatosPersonajes_Click(object sender, EventArgs e)
        {

            crearEnemigos(cantidadParticipantes);
            VentanaDatosPersonaje ventanaDatos = new VentanaDatosPersonaje(personajes);
            ventanaDatos.Show();
        }

        private void crearEnemigos(int cantidad)
        {
            do
            {
                agregarPersonajeALista(CreadorPersonajePrueba.GenerarPersonaje());

            } while (personajes.Count != cantidad);
        }

        private void agregarPersonajeALista(Personaje nuevoPersonaje)
        {
            personajes.Add(nuevoPersonaje);
        }

        private void btnCrearNuevoPerd_Click(object sender, EventArgs e)
        {
            Personaje nuevopersonaje = new Personaje();
            generarPersonaje(nuevopersonaje);
            agregarPersonajeALista(nuevopersonaje);
            MessageBox.Show("Personaje Creado con exito!!!", "Personaje Creado");
        }

        private void generarPersonaje(Personaje nuevoPersonaje)
        {
            nuevoPersonaje.Nombre = nombre.Text;
            nuevoPersonaje.Tipo = (TipoPersonaje)tipoPersonaje.SelectedIndex;
            nuevoPersonaje.Apodo = apodo.Text;
            nuevoPersonaje.FechaNacimiento = dateTimePicker1.Value;

            nuevoPersonaje.Edad = CreadorPersonajePrueba.generadorEdad(nuevoPersonaje.FechaNacimiento);
            nuevoPersonaje.Velocidad = CreadorPersonajePrueba.genererVelocidad();
            nuevoPersonaje.Destreza = CreadorPersonajePrueba.genererDestreza();
            nuevoPersonaje.Fuerza = CreadorPersonajePrueba.genererFuerza();
            nuevoPersonaje.Armadura = CreadorPersonajePrueba.genererArmadura();
        }

        private bool camposLlenos()
        {
            return tipoPersonaje.SelectedIndex != -1 && nombre.TextLength != 0 && apodo.TextLength != 0;
        }

        private void habilitarBotonCrearPersonaje()
        {
            btnCrearNuevoPerd.Enabled = camposLlenos();
        }

        private void tipoPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        private void apodo_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }
    }
}
