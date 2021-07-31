using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JuegoRol
{
    public static class CreadorPersonajePrueba
    {
        static Random aleatorio = new Random();
        public static Personaje GenerarPersonaje(List<string> nombresPokemones)
        {
           
            Personaje nuevo = new Personaje();

            nuevo.Tipo = generarTipo();
            nuevo.Nombre = generarNombre(nombresPokemones);
            nuevo.Apodo = generarApodo();
            nuevo.FechaNacimiento = generadorFechaNacimiento();
            nuevo.Edad = generadorEdad(nuevo.FechaNacimiento);

            return nuevo;
        }

        //Obtención de los Datos
        static TipoPersonaje generarTipo()
        {
            return (TipoPersonaje)aleatorio.Next(10);
        }

        private static string generarNombre(List<string> nombreElegibles)
        {
            int numNombre = aleatorio.Next(nombreElegibles.Count);
            
            return nombreElegibles[numNombre].Substring(0, 1).ToUpper() + nombreElegibles[numNombre].Substring(1);
        }

        private static string generarApodo()
        {
            string[] apodos = { "The Slayer", "Firebane", "Dragonblade", "The Bull", "Bonestrike", "The Executioner", "Dead Claw", "Voidblood", "Greatstare", "Demonsword" };

            return apodos[aleatorio.Next(10)];
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

    }
  
}
