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
    public partial class VentanaBatalla : Form
    {
        List<Personaje> personajes;
        int MDP = 50000;
        int numAtaque;
        public VentanaBatalla(List<Personaje> personajes)
        {
            InitializeComponent();
            this.personajes = personajes;
            inicializarVentana(personajes);
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

        private int poderDisparo(Personaje participante)
        {
            return participante.Destreza * participante.Fuerza * participante.Nivel;
        }

        private float valorAtaque(float ED, float PD)
        {
            return PD * ED;
        }

        private int poderDefenza(Personaje participante)
        {
            return participante.Armadura * participante.Velocidad;
        }

        private float danioProvocado(int MDP, float VA, float ED, float PDEF)
        {
            return ((float)((VA * ED) - PDEF)/MDP)*100;
        }

        private float actualizarSalud(Personaje participante, float DProv)
        {
            float salud = participante.Salud - DProv;
            if (salud < 0)
            {
                participante.Salud = 0;
            }
            else
            {
                participante.Salud = (int)salud;
            }

            return participante.Salud;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if(personajes.Count != 1)
            {
                inicializarVentana(personajes);
            }
            else
            {
                MessageBox.Show("El ganador es " + personajes.ElementAt(0).Nombre, "Ganador!!!");
                Close();
                personajes.Clear();
            }
        }

        private float[] generarValoresCombate(Personaje participante)
        {
            float[] valoresCombate = new float[4];
            Random ED = new Random();

            valoresCombate[0] = poderDisparo(participante);
            valoresCombate[1] = (float)ED.Next(1, 20);
            valoresCombate[2] = valorAtaque(valoresCombate[1], valoresCombate[0]);
            valoresCombate[3] = poderDefenza(participante);

            return valoresCombate;
        }

        private void premioGanador(Personaje participante)
        {
            
            Random num = new Random();
            participante.Salud = 100;
            int catSeleccionada = num.Next(6);

            switch (catSeleccionada)
            {
                case 0:
                    participante.Velocidad += num.Next(1, 10);
                    break;
                case 1:
                    participante.Destreza += num.Next(1, 10);
                    break;
                case 2:
                    participante.Fuerza += num.Next(1, 10);
                    break;
                case 3:
                    participante.Nivel += 1;
                    break;
                default:
                    participante.Armadura += num.Next(1, 10);
                    break;
            }

        }

        private int siguenVivos()
        {
            if(personajes.ElementAt(0).Salud > 0 && personajes.ElementAt(1).Salud > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnIniciarBatalla_Click(object sender, EventArgs e)
        {
            if(numAtaque < 3 && siguenVivos() == 1)
            {
                Personaje personaje1 = personajes.ElementAt(0);
                Personaje personaje2 = personajes.ElementAt(1);

                float[] valoresP1 = generarValoresCombate(personaje1);
                float[] valoresP2 = generarValoresCombate(personaje2);

                float danioP1 = danioProvocado(MDP, valoresP2[2], valoresP2[1], valoresP1[3]);
                float danioP2 = danioProvocado(MDP, valoresP1[2], valoresP1[1], valoresP2[3]);

                label4.Text = actualizarSalud(personaje1,danioP1).ToString();
                label5.Text = actualizarSalud(personaje2, danioP2).ToString();

                btnIniciarBatalla.Text = "Ataque" + (numAtaque + 1).ToString();

                numAtaque++;
            }
            else
            {
                btnIniciarBatalla.Enabled = false;
                btnSig.Enabled = true;
                if(personajes.ElementAt(0).Salud < personajes.ElementAt(1).Salud)
                {
                    label6.Text = "Perdedor :(";
                    label7.Text = "Ganador!!!";
                    premioGanador(personajes.ElementAt(1));
                    personajes.RemoveAt(0);
                }
                else
                {
                    label7.Text = "Perdedor :(";
                    label6.Text = "Ganador!!!";
                    premioGanador(personajes.ElementAt(0));
                    personajes.RemoveAt(1);
                }
            }
        }
    }
}
