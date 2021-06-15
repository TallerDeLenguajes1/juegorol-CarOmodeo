using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol
{
    public static class CreadorPersonajePrueba
    {
        static Random aleatorio = new Random();
        public static Personaje GenerarPersonaje()
        {
           
            Personaje nuevo = new Personaje();

            nuevo.Tipo = generarTipo();
            nuevo.Nombre = generarNombre();
            nuevo.Apodo = generarApodo();
            nuevo.FechaNacimiento = generadorFechaNacimiento();
            nuevo.Edad = generadorEdad(nuevo.FechaNacimiento);
            nuevo.Salud = 100;

            nuevo.Velocidad = genererVelocidad();
            nuevo.Destreza = genererDestreza();
            nuevo.Fuerza = genererFuerza();
            nuevo.Nivel = 1;
            nuevo.Armadura = genererArmadura();

            return nuevo;
        }

        //Obtención de los Datos
        static TipoPersonaje generarTipo()
        {

            int num = aleatorio.Next(5);
            TipoPersonaje tipo;

            switch (num)
            {
                case 0:
                    tipo = TipoPersonaje.Humano;
                    break;
                case 1:
                    tipo = TipoPersonaje.Orco;
                    break;
                case 2:
                    tipo = TipoPersonaje.Elfo;
                    break;
                case 3:
                    tipo = TipoPersonaje.Enano;
                    break;                   
                default:
                    tipo = TipoPersonaje.Hobbit;
                    break;
            }
            return tipo;
        }

        private static string generarNombre()
        {
            string[] nombres = { "Carlos", "Maria", "Pedro", "Juan", "Lucia" };
            string[] apellidos = { "Perez", "Gonzales", "Ramirez", "Albornoz", "Torres" };

            int numNombre = aleatorio.Next(5);
            int numApellido = aleatorio.Next(5);

            return nombres[numNombre] + " " + apellidos[numApellido];
        }

        private static string generarApodo()
        {
            string[] apodos = { "Pepe", "Gordo", "Alto", "Hierro", "Flash" };

            int numApodo = aleatorio.Next(5);

            return apodos[numApodo];
        }

        private static DateTime generadorFechaNacimiento()
        {
            DateTime inicio = new DateTime(1721, 1, 1);
            int range = (DateTime.Today - inicio).Days;
            return inicio.AddDays(aleatorio.Next(range)).Date;
        }

        public static int generadorEdad(DateTime fechaNacimiento)
        {
            return DateTime.Today.Year - fechaNacimiento.Year;
        }

        //Obtencion de las Caracteristicas

        public static int genererVelocidad()
        {
            return aleatorio.Next(1, 11);
        }

        public static int genererDestreza()
        {
            return aleatorio.Next(1, 6);
        }

        public static int genererFuerza()
        {
            return aleatorio.Next(1, 11);
        }

        public static int genererArmadura()
        {
            return aleatorio.Next(1, 11);
        }

    }
}
