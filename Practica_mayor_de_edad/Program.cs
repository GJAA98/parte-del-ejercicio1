using System;

namespace Practica_mayor_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserte el edad:");
            string valor = Console.ReadLine();
            
            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.Edad = int.Parse(valor);

            Console.WriteLine("Datos insertados:");
            Console.WriteLine("Nombre:" + persona.Nombre);
            Console.WriteLine("Edad:" + persona.Edad);

            if (persona.Edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");                
            }
        }
    }
}
