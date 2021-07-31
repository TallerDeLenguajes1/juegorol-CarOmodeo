using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using JuegoRol.Vistas;
using System.Text.Json;

namespace JuegoRol
{
    public partial class VentanaBatalla : Form
    {
        List<Personaje> personajes;
        int numAtaque;
        private const int MDP = 5000;
        public VentanaBatalla(List<Personaje> personajes)
        {
            InitializeComponent();
            this.personajes = personajes;
            inicializarVentana(personajes);
            btnBatallaAuto.Enabled = false;
        }

        private void inicializarVentana(List<Personaje> participantes)
        {
            numAtaque = 0;
            label1.Text = personajes.ElementAt(0).Nombre;
            label3.Text = personajes.ElementAt(1).Nombre;
            label4.Text = personajes.ElementAt(0).Salud.ToString();
            label5.Text = personajes.ElementAt(1).Salud.ToString();
            btnIniciarBatalla.Enabled = true;
            btnIniciarBatalla.Text = "Iniciar Batalla";
            label6.Text = " ";
            label7.Text = " ";
            btnSig.Enabled = false;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (personajes.Count != 1)
            {
                inicializarVentana(personajes);
                if (personajes.Count == 2)
                {
                    btnSig.Text = "Mostrar Ganador!!!";
                }
            }
            else
            {
                MessageBox.Show("El ganador es " + personajes.ElementAt(0).Nombre, "Ganador!!!");
                Close();
            }
        }

        private void premioGanador(Personaje participante)
        {
            if (personajes.Count == 1)
            {
                Ganador nuevoGanador = new Ganador();

                nuevoGanador.Nombre = participante.Nombre;
                nuevoGanador.Puntos = participante.Salud;
                ManejadorJason.guardarGanador(nuevoGanador);
            }
            else
            {
                Random num = new Random();
                participante.Salud = 100;
                int catSeleccionada = num.Next(5);

                switch (catSeleccionada)
                {
                    case 0:
                        participante.Velocidad += num.Next(1, 3);
                        break;
                    case 1:
                        participante.Destreza += num.Next(1, 3);
                        break;
                    case 2:
                        participante.Fuerza += num.Next(1, 3);
                        break;
                    case 3:
                        participante.Nivel += 1;
                        break;
                    case 4:
                        participante.Armadura += num.Next(1, 3);
                        break;
                }
            }

        }

        private int siguenVivos()
        {
            if (personajes.ElementAt(0).Salud > 0 && personajes.ElementAt(1).Salud > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private float danioProvocadoPorEnemigo(Personaje participante, Personaje enemigo)
        {
            return Math.Abs((float)(enemigo.valorAtaque() - participante.poderDefenza()) / MDP * 100);
        }

        private void actualizarVentanaBatalla(Personaje p1, Personaje p2)
        {
            float danioP1 = danioProvocadoPorEnemigo(p1, p2);
            float danioP2 = danioProvocadoPorEnemigo(p2, p1);
            label4.Text = p1.actualizarSalud(danioP1).ToString();
            label5.Text = p2.actualizarSalud(danioP2).ToString();

            btnIniciarBatalla.Text = "Ataque " + (numAtaque + 1).ToString();
        }        

        private void btnIniciarBatalla_Click(object sender, EventArgs e)
        {
            if(numAtaque == 0)
            {
                btnIniciarBatalla.Text = "Ataque 1";
                btnBatallaAuto.Enabled = true;
                numAtaque++;
            }
            else
            {
                if (numAtaque < 3 && siguenVivos() == 1)
                {
                    actualizarVentanaBatalla(personajes.ElementAt(0), personajes.ElementAt(1));
                    numAtaque++;
                }
                else
                {
                    asignarGanadorYPerdedor();
                }
            }
        }

        private void asignarGanadorYPerdedor()
        {
            btnIniciarBatalla.Enabled = false;
            btnBatallaAuto.Enabled = false;
            btnSig.Enabled = true;
            if (personajes.ElementAt(0).Salud < personajes.ElementAt(1).Salud)
            {
                label4.Text = "Perdedor :(";
                label5.Text = "Ganador!!!";
                personajes.RemoveAt(0);
                premioGanador(personajes.ElementAt(0));
            }
            else
            {
                label5.Text = "Perdedor :(";
                label4.Text = "Ganador!!!";
                personajes.RemoveAt(1);
                premioGanador(personajes.ElementAt(0));
            }
        }

        private void btnBatallaAuto_Click(object sender, EventArgs e)
        {
            if(numAtaque == 0)
            {
                numAtaque++;
            }

            while(numAtaque < 3 && siguenVivos() == 1)
            {
                actualizarVentanaBatalla(personajes.ElementAt(0), personajes.ElementAt(1));
                numAtaque++;
            }

            asignarGanadorYPerdedor();
        }
    }
}
