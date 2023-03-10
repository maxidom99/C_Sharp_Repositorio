using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;
            string linea;
            Console.Write("Ingrese un dia DD/mm/aaaa: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.Write("Ingrese un mes dd/MM/aaaa: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            Console.Write("Ingrese un dia dd/mm/AAAA: ");
            linea = Console.ReadLine();
            anio = int.Parse(linea);

            if (dia > 0 && dia <= 31)
            {  }
            else { Console.WriteLine("Error en el dia ingresado"); }
            if (mes > 0 && mes <= 12)
            {  }
            else
            {
                Console.Write("El mes ingresado no es correcto");
            }
                if (anio > 1800 && anio <= 2023)
                {
                Console.Write("Usted ingreso la siguiente fecha: " + dia+"/"+mes+"/"+anio); }
                 else { Console.Write("El ano ingresado no es correcto"); }
            if (dia == 31 && mes == 11 || dia == 31 && mes == 02 || dia == 31 && mes == 04 || dia == 31 && mes == 06 || dia == 31 && mes == 09 || dia == 30 && mes == 02 || dia == 29 && mes == 02)
            {
                Console.Write(" Gracias por ingresar la fecha solicitada por mi, aunque ingresaste todo mal flaco");
            }
            else { }
             if (dia == 25 && mes == 12)
            { Console.Write(" y justo es Navidad :D " + dia + "/" + mes); 
            } else {  } 
        
            
            Console.ReadKey();
        }
    }
}
