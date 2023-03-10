using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vector._4
{
    /*
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

          public void Acumulado ()
        {
            int suma = 0;
            for (int x = 1; x < 8; x++)
            {
                suma = suma + nums[x];
            } Console.WriteLine("El valor acumulado de los numeros ingresados es de: " + suma);
        }

        public void MayoresQue ()
        {
            int suma36 = 0;
            for (int x = 0; x < 8; x ++)
            {
                if (nums[x] > 36) 
                {
                    suma36 = suma36 + nums[x];

                }
            }Console.WriteLine("El valor de los numeros ingresados > 36 es de: " + suma36);
        }

        public void Cantidad()
        {
            int cant = 0;
            for (int x = 0; x < 8; x++)
            {
                if (nums[x] > 50)
                {
                    cant ++;
                }
            }Console.WriteLine("Los numeros ingresados con valor > 50 son: " + cant);
        }

      
        static void Main(string[] args)
        {
            Vector4 v1= new Vector4();
            v1.Inicializar();
            v1.Acumulado();
            v1.MayoresQue();
            v1.Cantidad();
            
            */


    /*
        internal class Vector5
        {
            private int[] num1, num2,num3;
            private String linea;
            public void Carga()
            {
                num1 = new int[4];
                num2 = new int[4];
                num3 = new int[4];

                for (int x = 0; x < 4; x++)
                {
                    Console.WriteLine("Ingresar los numeros del primer conjunto: ");
                    linea = Console.ReadLine();
                    num1[x] = int.Parse(linea);
                }
                Console.WriteLine("--- FIN PRIMER SEGMENTO ---");
                Console.WriteLine("        --- ---- ---");
                Console.WriteLine("--- FIN PRIMER SEGMENTO ---");
                for (int x = 0; x < 4; x++)
                {

                    Console.WriteLine("Ingresar los numeros del segundo conjunto: ");
                    linea = Console.ReadLine();
                    num2[x] = int.Parse(linea);
                }

            }

            public void Vector3()
            {
                for (int x = 0; x < 4; x++)
                {
                    num3[x] = num1[x] + num2[x];
                }
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(num3[x] + " - ");
                }
            }

           public void Suma()
            {
                int v1, v2;
                v1 = 0; v2 = 0;
                int suma = 0;
                for (int x = 0; x < 4; x++)
                {
                    v1 = v1 + num1[x];
                    v2 = v2 + num2[x];
                }
                suma = v1 + v2;
                Console.WriteLine("La suma de los valores ingresados es = " + suma);
            }

            static void Main(string[] args)
            { 
                Vector5 a = new Vector5();
                a.Carga();
                a.Suma();
                a.Vector3();

        */

    /*
internal class Vector6
    { 
        private int[] CurA, CurB;

        public void Carga() 
        {
            CurA= new int[5];
            CurB= new int[5];
            String linea;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese las notas de los alumnos del Curso A: ");
                linea = Console.ReadLine();
                CurA[x] = int.Parse(linea);
            }
            Console.WriteLine("--- FIN PRIMER CURSO ---");
            Console.WriteLine("        --- ---- ---");
            Console.WriteLine("--- COMIENZO SEGUNDO CURSO ---");
            for (int x =0; x < 5; x++)
            {
                Console.WriteLine("Ingrese las notas de los alumnos del Curso B: ");
                linea = Console.ReadLine();
                CurB[x] = int.Parse(linea);
            }
        }

        public void Prom() 
        {
            float promA,promB,sumaA,sumaB;
            sumaA = 0;sumaB = 0; promA = 0; promB = 0;
            for(int x = 0;x < 5; x++)
            {
                sumaA = sumaA + CurA[x];
                sumaB = sumaB + CurB[x];
            }
            promA = sumaA / 5; promB = sumaB /5;
            if (promA > promB)
            {
                Console.WriteLine("El promedio de los parciales del Curso A es mayor: " + promA);
            } else
            {
                Console.WriteLine("El promedio de los parciales del Curso B es mayor: " + promB);
            }
        }
        static void Main(string[] args)
        { 
            Vector6 Prueba = new Vector6();
            Prueba.Carga();
            Prueba.Prom();
    */

    /*
    internal class Vector7
    {
        private int[] num;

        public void Carga()
        { num = new int[10];
            String linea;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                linea = Console.ReadLine();
                num[x] = int.Parse(linea);
            }
        }
        public void Verificar()
        { int order = 1;
            for (int x = 0; x < 9; x++)
            {
                if (num[x + 1] < num[x])
                {                   
                    order = 0;
                }
                Console.WriteLine("Verificando numero actual  " + num[x + 1] + " / " + num[x] + " Contra el anterior");
            }
                if (order == 1)
                {
                    Console.WriteLine("Esta ORDENADO el vector de menor a mayor.");
                }
                else
                {
                    Console.WriteLine("Esta DESORDENADO el vector de menor a mayor.");
                }
            
            }
        static void Main(string[] args)
        { 
            Vector7 a = new Vector7();
            a.Carga();
            a.Verificar();
    */



    /*
    class Vector8
    {
        private int[] sueldos;

        public void Cargar()
        {
            Console.Write("Cuantos sueldos cargará:");
            string linea;
            linea = Console.ReadLine();
            int cant = int.Parse(linea);
            sueldos = new int[cant];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Vector8 pv = new Vector8();
            pv.Cargar();
            pv.Imprimir();

    */

    /*
    class Vector9
    {
        private int[] elementos;

        public void Carga()
        {
            Console.WriteLine("Cuantos elementos ingresara: ");
            String linea;
            linea = Console.ReadLine();
            int cant = int.Parse(linea);
            elementos = new int[cant];
            for (int x = 0 ; x < elementos.Length; x++) 
            {
                Console.WriteLine("Ingrese los elementos 1 a la vez: ");
                linea = Console.ReadLine();
                elementos[x] = int.Parse(linea);
            }
        }

        public void Suma()
        {
            int suma = 0;

            for(int x = 0;x < elementos.Length; x++)
            {
                suma = suma + elementos[x];
            }
            Console.WriteLine("La suma de todos los elementos es = " + suma);
        }
        static void Main(string[] args)
        { 
            Vector9 a1 = new Vector9();
            a1.Carga();
            a1.Suma();
           
    */
    /*
    class PruebaVector10
    {
        private string[] nombres;
        private int[] edades;

        public void Cargar()
        {
            nombres = new string[5];
            edades = new int[5];
            string linea;
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre:");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese edad:");                
                linea = Console.ReadLine();
                edades[f] = int.Parse(linea);
            }
        }

        public void MayoresEdad()
        {
            Console.WriteLine("Personas mayores de edad.");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edades[f] >= 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector10 pv = new PruebaVector10();
            pv.Cargar();
            pv.MayoresEdad();
    */


    class Vector11
    {
        private int[] sueldos;
        private string[] nombres;

        public void Carga()
        {
            nombres = new string[5];
            sueldos = new int[5];
            for (int x = 0; x < nombres.Length; x++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombres[x] = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo del empleado: ");
                string linea;
                linea = Console.ReadLine();
                sueldos[x] = int.Parse(linea);
            }
        }
        
        public void MuestraMayor()
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es " + nombres[pos]);
            Console.WriteLine("Tiene un sueldo:" + mayor);
        }


        static void Main(string[] args)
        { 
            Vector11 a1= new Vector11();
            a1.Carga();
            a1.MuestraMayor();
            Console.ReadKey();
            
        }
    }
}
