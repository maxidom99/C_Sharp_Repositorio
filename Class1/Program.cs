using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Persona
    {
        private String nombre;
        private int edad;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        { Console.WriteLine("Datos de la persona");
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }
        public void EsMayorEdad()
        { if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad, tiene exactamente " + edad + " años");
            } else { Console.WriteLine(nombre + " es menor de edad, tiene exactamente " + edad + "años");}        
            } 
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Inicializar();
            persona1.Imprimir();
            persona1.EsMayorEdad();
            Console.ReadKey();
        }
    }
}
