﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperficieCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int superficie;
            String linea;
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            linea= Console.ReadLine();
            lado = int.Parse(linea);
            superficie = lado * lado;
            Console.Write("La superficie del cuadrado es: ");
            Console.Write(superficie);
            Console.ReadKey();

        }
    }
}
