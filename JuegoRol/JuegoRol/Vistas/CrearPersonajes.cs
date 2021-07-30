using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JuegoRol
{
    public partial class FormCrearPersonaje : Form
    {
        List<Personaje> personajes = new List<Personaje>();
        int cantidadParticipantesMax = 2;
        List<string> nombresPokemones;
        public FormCrearPersonaje(List<string> listaPokemones)
        {
            InitializeComponent();
            inicializarComboBoxTipos();
            setearDateTimePicker();
            this.nombresPokemones = listaPokemones;
        }

        private void inicializarComboBoxTipos()
        {
            tipoPersonaje.Items.Add("Fuego");
            tipoPersonaje.Items.Add("Planta");
            tipoPersonaje.Items.Add("Eléctrico");
            tipoPersonaje.Items.Add("Fantasma");
            tipoPersonaje.Items.Add("Volador");
            tipoPersonaje.Items.Add("Volador");
            tipoPersonaje.Items.Add("Lucha");
            tipoPersonaje.Items.Add("Tierra");
            tipoPersonaje.Items.Add("Agua");
            tipoPersonaje.Items.Add("Psíquico");
            tipoPersonaje.Items.Add("Roca");
        }

        private void cargarComboBoxPersonajes(Personaje nuevoPersonaje)
        {
            comboBoxPersonajes.Items.Add(nuevoPersonaje.Nombre);
        }

        private void setearDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void btnPersAleatorio_Click(object sender, EventArgs e)
        {
            Personaje nuevoPersonaje = CreadorPersonajePrueba.GenerarPersonaje(nombresPokemones);
            agregarPersonajeALista(nuevoPersonaje);
            comboBoxPersonajes.SelectedIndex = personajes.IndexOf(nuevoPersonaje);
            MessageBox.Show("Personaje Aleatorio creado con exito!!!", "Personaje Aleatorio Creado");
            if (controlCantMaxPersonajes(personajes))
            {
                deshabilitarBotones_creacionPersonajes();
            }            
        }

        private void btnCrearEnemigos_Click(object sender, EventArgs e)
        {
            List<string> nombresElegibles = new List<string>(nombresPokemones);
            int cont = 0;
            do
            {
                Personaje nuevoEnemigo = CreadorPersonajePrueba.GenerarPersonaje(nombresElegibles);
                nombresElegibles.Remove(nuevoEnemigo.Nombre.ToLower());
                agregarPersonajeALista(nuevoEnemigo);
                cont++;

            } while (personajes.Count != cantidadParticipantesMax);
            MessageBox.Show("Se crearon " + cont + " enemigos con exito!!!", "Creación de enemigos");
            if (controlCantMaxPersonajes(personajes))
            {
                deshabilitarBotones_creacionPersonajes();
            }                  
        }

        private void agregarPersonajeALista(Personaje nuevoPersonaje)
        {
            personajes.Add(nuevoPersonaje);
            cargarComboBoxPersonajes(nuevoPersonaje);
        }

        private void btnCrearNuevoPerd_Click(object sender, EventArgs e)
        {
            Personaje nuevoPersonaje = new Personaje();
            generarPersonaje(nuevoPersonaje);
            agregarPersonajeALista(nuevoPersonaje);
            comboBoxPersonajes.SelectedIndex = personajes.IndexOf(nuevoPersonaje);
            MessageBox.Show("Personaje creado con exito!!!", "Personaje Creado");
            if (controlCantMaxPersonajes(personajes))
            {
                deshabilitarBotones_creacionPersonajes();
            }            
        }

        private void generarPersonaje(Personaje nuevoPersonaje)
        {
            nuevoPersonaje.Nombre = nombre.Text;
            nuevoPersonaje.Tipo = (TipoPersonaje)tipoPersonaje.SelectedIndex;
            nuevoPersonaje.Apodo = apodo.Text;
            nuevoPersonaje.FechaNacimiento = dateTimePicker1.Value;

            nuevoPersonaje.Edad = CreadorPersonajePrueba.generadorEdad(nuevoPersonaje.FechaNacimiento);
        }

        private bool controlCantMaxPersonajes(List<Personaje> listaPersonajes)
        {
            return listaPersonajes.Count == cantidadParticipantesMax;
        }

        private void deshabilitarBotones_creacionPersonajes()
        {
            btnCrearNuevoPerd.Enabled = false;
            btnCrearEnemgos.Enabled = false;
            btnPersAleatorio.Enabled = false;            
        }

        private void habilitarBotones_creacionPersonajes()
        {
            btnCrearNuevoPerd.Enabled = true;
            btnCrearEnemgos.Enabled = true;
            btnPersAleatorio.Enabled = true;
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

        private void comboBoxPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBoxPersonajes.SelectedIndex;
            inicializarPersonaje(personajes.ElementAt(i));

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

        private void borrarDatosComboBox()
        {
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";

            label12.Text = " ";
            label13.Text = " ";
            label14.Text = " ";
            label15.Text = " ";
            label16.Text = " ";
        }

        private void btnIrBatalla_Click(object sender, EventArgs e)
        {
            if(personajes.Count < cantidadParticipantesMax)
            {
                MessageBox.Show("Debe crear sus enemigos...", "No puede ir a la Batalla Solo");
            }
            else
            {
                VentanaBatalla ventanaNuevaBatalla = new VentanaBatalla(personajes);
                ventanaNuevaBatalla.ShowDialog();
                nuevaPartida();
            }
        }

        private void nuevaPartida()
        {
            DialogResult respuesta = MessageBox.Show("Desea jugar una partida nueva?", "Nueva Partida", MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.No)
            {
                Close();
            }
            else
            {
                inicializarNuevaPartida();
            }
        }

        private void inicializarNuevaPartida()
        {
            personajes.Clear();
            habilitarBotones_creacionPersonajes();
            comboBoxPersonajes.DataSource = null;
            comboBoxPersonajes.Items.Clear();
            borrarDatosComboBox();
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

            foreach (Personaje personaje in personajes)
            {
                escribirJugadore.WriteLine("{0};{1};{2}", personaje.Nombre, personaje.Tipo, personaje.Salud);
            }
            escribirJugadore.Close();
        }

        private void guardarArchivoJson()
        {

            FileStream jugadores = new FileStream("ListaJugadores.Json", FileMode.Create);
            StreamWriter escribirJugadore = new StreamWriter(jugadores);

            foreach (Personaje personaje in personajes)
            {
                string strJson = JsonSerializer.Serialize(personaje);
                escribirJugadore.WriteLine("{0}", strJson);
            }
            escribirJugadore.Close();
        }
    }
}
