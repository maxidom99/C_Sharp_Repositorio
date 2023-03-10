using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            double numero;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            /*Console.Write("Ingrese segunda valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);*/
            if (num1 < 10 && num1 > 0)
            {
                Console.WriteLine("Tiene una cifra " + num1);
            } else
            { if (num1 < 100 && num1 > 9)
                {
                    Console.WriteLine("Tiene dos cifras " + num1);
                } else { if (num1 < 1000 && num1 > 99)
                    { Console.WriteLine("Tiene tres cifras: " + num1); }
                } else
                {
                    Console.WriteLine("Error, tiene 4 o mas cifras: " + num1);
                }
            }

            /*}else{
                    if (num1 < 1000 && num1 > 99)
                    {

                    Console.WriteLine("Tiene tres cifras: " + num1);
                    }
                    else {
                    Console.WriteLine("Error, tiene 4 o mas cifras: " + num1); 
                }*/
                }
            Console.ReadKey();
        }
    }
}
