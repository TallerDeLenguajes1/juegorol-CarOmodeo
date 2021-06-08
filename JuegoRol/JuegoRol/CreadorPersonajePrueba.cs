using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol
{
    class CreadorPersonajePrueba
    {
        Random aleatorio = new Random();
        public CreadorPersonajePrueba()
        {            

        }

        public Personajes GenerarPersonaje()
        {
            Personajes nuevo = new Personajes();

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
        TipoPersonajes generarTipo()
        {
            int num = aleatorio.Next(5);
            TipoPersonajes tipo;

            switch (num)
            {
                case 0:
                    tipo = TipoPersonajes.Humano;
                    break;
                case 1:
                    tipo = TipoPersonajes.Orco;
                    break;
                case 2:
                    tipo = TipoPersonajes.Elfo;
                    break;
                case 3:
                    tipo = TipoPersonajes.Enano;
                    break;                   
                default:
                    tipo = TipoPersonajes.Hobbit;
                    break;
            }
            return tipo;
        }

        string generarNombre()
        {
            string[] nombres = { "Carlos", "Maria", "Pedro", "Juan", "Lucia" };
            string[] apellidos = { "Perez", "Gonzales", "Ramirez", "Albornoz", "Torres" };

            int numNombre = aleatorio.Next(5);
            int numApellido = aleatorio.Next(5);

            return nombres[numNombre] + apellidos[numApellido];
        }

        string generarApodo()
        {
            string[] apodos = { "Pepe", "Gordo", "Alto", "Hierro", "Flash" };

            int numApodo = aleatorio.Next(5);

            return apodos[numApodo];
        }

        DateTime generadorFechaNacimiento()
        {
            DateTime inicio = new DateTime(1721, 1, 1);
            int range = (DateTime.Today - inicio).Days;
            return inicio.AddDays(aleatorio.Next(range));
        }

        int generadorEdad(DateTime fechaNacimiento)
        {
            return DateTime.Today.Year - fechaNacimiento.Year;
        }

        //Obtencion de las Caracteristicas

        int genererVelocidad()
        {
            return aleatorio.Next(1, 11);
        }

        int genererDestreza()
        {
            return aleatorio.Next(1, 6);
        }

        int genererFuerza()
        {
            return aleatorio.Next(1, 11);
        }

        int genererArmadura()
        {
            return aleatorio.Next(1, 11);
        }

    }
}
