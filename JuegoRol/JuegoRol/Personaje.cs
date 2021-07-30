using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol
{
   
    public enum TipoPersonaje
    {
        Fuego,
        Planta,
        Eléctrico,
        Fantasma,
        Volador,
        Lucha,
        Tierra,
        Agua,
        Psíquico,
        Roca
    }

    public class Personaje
    {
        static Random aleatorio = new Random();
        private TipoPersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime fechaNacimiento;
        private int edad;
        private int salud;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        public Personaje()
        {
            nivel = 1;
            salud = 100;
            velocidad = generarAleatorio(1, 10);
            destreza = generarAleatorio(1, 5);
            fuerza = generarAleatorio(1, 10);
            armadura = generarAleatorio(1, 10);
        }

        internal TipoPersonaje Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud 
        {
            get => salud;

            set
            {
                salud = value;
                if(salud <= 0)
                {
                    salud = 0;
                }
            }
        }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }

        public int generarAleatorio(int inicio, int fin)
        {
            return aleatorio.Next(inicio, fin + 1);
        }

        public int poderDisparo()
        {
            return Destreza * Fuerza * Nivel;
        }

        public float valorAtaque()
        {
            Random efectividadDisparo = new Random();
            return poderDisparo() * efectividadDisparo.Next(1,101);
        }

        public int poderDefenza()
        {
            return Armadura * Velocidad;
        }

        public float actualizarSalud(float DProv)
        {
            Salud = Salud - (int)DProv;
           return Salud;
        }
    }



   
}
