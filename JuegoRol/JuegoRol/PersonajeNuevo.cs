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
    public partial class Personaje_Nuevo : Form
    {
        public Personaje_Nuevo(Personajes nuevoPersonaje)
        {
            InitializeComponent();
            label1.Text = Convert.ToString(nuevoPersonaje.Tipo);
            label2.Text = nuevoPersonaje.Nombre;
            label3.Text = nuevoPersonaje.Apodo;
            label4.Text = Convert.ToString(nuevoPersonaje.FechaNacimiento);
            label5.Text = Convert.ToString(nuevoPersonaje.Edad);
            label6.Text = Convert.ToString(nuevoPersonaje.Salud);

            label12.Text = Convert.ToString(nuevoPersonaje.Velocidad);
            label13.Text = Convert.ToString(nuevoPersonaje.Destreza);
            label14.Text = Convert.ToString(nuevoPersonaje.Fuerza);
            label15.Text = Convert.ToString(nuevoPersonaje.Nivel);
            label16.Text = Convert.ToString(nuevoPersonaje.Armadura);
            
        }
    }
}
