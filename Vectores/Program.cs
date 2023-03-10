using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    /*
    internal class Vector1
    {
        private int[] sueldos;

        public void Carga()
        {
            sueldos = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Ingrese el valor del sueldo: ");
                String linea;
                linea = Console.ReadLine();
                sueldos[x] = int.Parse(linea); 
            }
        }

        public void Imprimir ()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.Write("(" + sueldos[f] + ")");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Vector1 v1 = new Vector1();
            v1.Carga();
            v1.Imprimir();

            */
    /*    
    internal class Vector2

        {
        private float[] alturas;
        private float promedio;
        public void Cargas()
        {
            alturas = new float[5];
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese una altura: ");
                String linea;
                linea = Console.ReadLine();
                alturas[x] = float.Parse(linea);
            }        
        }

        public void Promedio()
        {
            float suma = 0;
            for (int x = 0; x < 5; x++)
            {
                suma = suma + alturas[x];
            }
          promedio = suma / 5;
            Console.WriteLine("El promedio de las alturas es: " + promedio);
        }

        public void MayorMenor()
        {
            int mayor, menor;
            mayor = 0; menor = 0;
            for (int x = 0; x < 5; x++)
            {
                if (alturas[x] > promedio)
                {
                    mayor++;
                }

                else
                { if (alturas[x] < promedio)
                    {
                        menor++;
                    }
                }
                
            }
            Console.WriteLine("Cantidad de personas mayores al promedio: " + mayor);
            Console.WriteLine("Cantidad de personas menores al promedio: " + menor);
        }
            static void Main(string[] args)
            {
                Vector2 v2 = new Vector2();
                v2.Cargas();
                v2.Promedio();
                v2.MayorMenor();
    */

/*
    internal class Vector3
    {
        private float[] turnoMan;
        private float[] turnoTar;

        public void Cargar()
        {
            string linea;
            turnoMan = new float[4];
            turnoTar = new float[4];
 Console.WriteLine("En principio debera ingrear los sueldos de los empleados del turno matutino");
            for (int x = 0; x < 4; x++) {

                Console.WriteLine("Ingrese el sueldo del empleado: ");
                linea = Console.ReadLine();
                turnoMan[x] = float.Parse(linea);
            }
            Console.WriteLine("Ahora debera ingrear los sueldos de los empleados del turno vespertino");
            for (int x = 0; x < 4; x++)
            {

                Console.WriteLine("Ingrese el sueldo del empleado: ");
                linea = Console.ReadLine();
                turnoTar[x] = float.Parse(linea);
            }
        }

        public void CalcularGastos()
        {
            float man,tar;
            man = 0; tar = 0;

            for (int x = 0; x < 4; x++) { 
                man = man + turnoMan[x];
                tar = tar + turnoTar[x];
            }
            Console.WriteLine("El gasto de la empresa pagando los sueldos matutinos es de: " + man);
            Console.WriteLine("El gasto de la empresa pagando los sueldos vespertinos es de: " + tar);
        }
        static void Main(string[] args)
        { 
            Vector3 v1= new Vector3();
            v1.Cargar();
            v1.CalcularGastos();
               
 */

    internal class Vector4
    {
        private int[] nums;

        public void Inicializar()
        {
            String linea;
            nums = new int[8];
            for (int x = 0; x < 8; x++)
            {
            
                Console.WriteLine("Ingrese un valor: ");
                linea = Console.ReadLine();
                nums[x] = int.Parse(linea);
            
            }
        }

        static void Main(string[] args)
        { 

Console.ReadKey();
            }
        }
    }

