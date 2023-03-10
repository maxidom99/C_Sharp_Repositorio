using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    /*
        internal class Metodo1
        { 
    public void CargarValor()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }

        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Metodo1 tm = new Metodo1();
            tm.CargarValor();
        }
    */


    internal class Metodo2
    {
        public void Inicializar()
        {

            String linea;

            Console.WriteLine("Ingrese un valor: ");
            linea = Console.ReadLine();
           int num1 = int.Parse(linea);

            Console.WriteLine("Ingrese un segundo valor: ");
            linea = Console.ReadLine();
           int num2 = int.Parse(linea);

            Console.WriteLine("Ingrese un tercer valor: ");
            linea = Console.ReadLine();
           int num3 = int.Parse(linea);

            int mayor, menor;
            mayor = CalcularMayor(num1, num2, num3);
            menor = CalcularMenor(num1,num2,num3);
            Console.WriteLine("El valor mayor de los tres es: " + mayor);
            Console.WriteLine("El valor menor de los tres es: " + menor);
        }

        public int CalcularMayor(int n1, int n2, int n3)
        {
            int m;
            if (n1 > n2 && n1 > n3)
            {
                m = n1;
            }
            else
            {
                if (n2 > n3)
                {
                    m = n2;
                } else
                {
                    m = n3;
                }
            }
            return m;
        }

        public int CalcularMenor(int n1, int n2, int n3)
        {
            int m;
            if (n1 < n2 && n1 < n3)
            {
                m = n1;
            }
            else
            {
                if(n2 < n3)
                {
                    m = n2;
                }
                else
                {
                    m = n3;
                }
            } return m;
        }

        static void Main(string[] args)
        {
            Metodo2 mm = new Metodo2();
            mm.Inicializar();
            Console.ReadKey();
        }
    }
} 
