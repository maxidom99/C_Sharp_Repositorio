using System;

namespace Ejercicios_IF_Compuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo, suma, total;
            int anti;
            string linea;

            Console.WriteLine("Ingrese el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            Console.WriteLine("Ingrese hace cuantos anos trabaja el empleado: ");
            linea = Console.ReadLine();
            anti = int.Parse(linea);

            if (sueldo < 500 && anti >= 10)
            {
                suma = (sueldo * 20) / 2;
                total = suma + sueldo;
                Console.WriteLine("Usted obtuvo un 20% de aumento: " + total);
            }
            else { Console.WriteLine("Su sueldo sigue igual: " + sueldo); }
            if (sueldo < 500)
            {
                suma = (sueldo * 5) / 2;
                total = suma + sueldo;
                Console.WriteLine("Usted obtuvo un 5% de aumento: " + total);
            }
            else { Console.WriteLine("Su sueldo sigue igual: " + sueldo); }
            if (sueldo >= 500)
            {
                Console.WriteLine("El sueldo de usted es el mismo: " + sueldo);
            }
            else { }


        }
    }
}
