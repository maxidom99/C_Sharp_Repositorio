using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    /*
        class Matriz1
        {
            private int[,] mat;

            public void Cargar()
            {
                mat = new int[3, 5];
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        Console.Write("Ingrese componente:");
                        string linea;
                        linea = Console.ReadLine();
                        mat[f, c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        Console.Write(mat[f, c] + " ");
                    }
                    Console.WriteLine();
                }

            }

            static void Main(string[] args)
            {
                Matriz1 ma = new Matriz1();
                ma.Cargar();
                ma.Imprimir();

    */

    /*
    class Matriz2
    {
        private int[,] num;
        public void Carga()
        {
            string linea;
            num = new int[4, 4];
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine("Ingrese los numeros que componen la matriz: ");
                    linea = Console.ReadLine();
                    num[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(num[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------");
        }

        public void Imprimir4()
        {
            for(int f = 0; f < 4; f++)
            {
                    Console.Write(num[f, f] + " ");
                }
                Console.WriteLine();
            }
        
                static void Main(string[] args)
                {
                    Matriz2 prueba = new Matriz2();
                    prueba.Carga();
                    prueba.Imprimir();
                    prueba.Imprimir4();
                   
    */



    /*
    class Matriz3
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese componente:");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        public void PrimerFila()
            {
                Console.WriteLine("Primer fila de la matriz:");
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine(mat[0, c]);
                }
            }

            public void UltimaFila()
            {
                Console.WriteLine("Ultima fila de la matriz:");
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine(mat[2, c]);
                }
            }

            public void PrimerColumna()
            {
                Console.WriteLine("Primer columna:");
                for (int f = 0; f < 3; f++)
                {
                    Console.WriteLine(mat[f, 0]);
                }
            }

            static void Main(string[] args)
            {
                Matriz3 ma = new Matriz3();
                ma.Cargar();
                ma.PrimerFila();
                ma.UltimaFila();
                ma.PrimerColumna();
               
    
    */


    /*
    class Matriz4
    { 
        private int[,] mat;

        public void CargaDatos1()
        {
            mat = new int[2, 5];

            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.WriteLine("Ingrese elementos de la FILA: " + f + " y de la COLUMNA: " + c + " : ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }


        public void Imprimir()
        {
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

            static void Main(string[] args)
        { 
            Matriz4 mat = new Matriz4();
            mat.CargaDatos1();
            mat.Imprimir();

*/
    /*
    class Matriz5
        {
            private int[,] mat;

            public void Cargar()
            {
            //Primero declaro todas las variables y guardo las cantidades dentro de la matriz , declarando new int [,]
                Console.Write("Cuantas fila tiene la matriz:");
                string linea;
                linea = Console.ReadLine();
                int filas = int.Parse(linea);
                Console.Write("Cuantas columnas tiene la matriz:");
                linea = Console.ReadLine();
                int columnas = int.Parse(linea);
                mat = new int[filas, columnas];
            
            //Comienza el for que guardara el valor de cada celda dentro de la matriz
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    for (int c = 0; c < mat.GetLength(1); c++)
                    {
                        Console.Write("Ingrese componente:");
                        linea = Console.ReadLine();
                        mat[f, c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    for (int c = 0; c < mat.GetLength(1); c++)
                    {
                        Console.Write(mat[f, c] + " ");
                    }
                    Console.WriteLine();
                }
            }



            public void ImprimirUltimaFila()
            {
                Console.WriteLine("Ultima fila");
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[mat.GetLength(0) - 1, c] + " ");
                }
            }

            static void Main(string[] args)
            {
                Matriz5 ma = new Matriz5();
                ma.Cargar();
                ma.Imprimir();
                ma.ImprimirUltimaFila();
                Console.ReadKey();
            }
        }
    }
*/

    /*
class Matriz6
{
        private int[,] matriz;

        public void Carga()
        {
            Console.WriteLine("Ingrese cuantas filas tendra la matriz: ");
            string linea;
            linea = Console.ReadLine();
            int filas;
            filas = int.Parse(linea);

            Console.WriteLine("Ingrese cuantas columnas tendra la matriz: ");
            linea = Console.ReadLine();
            int columnas;
            columnas = int.Parse(linea);
            matriz = new int[filas, columnas];

            for (int f = 0; f < matriz.GetLength(0); f ++) {
            
                for (int c = 0; c < matriz.GetLength(1); c ++)
                {
                    Console.WriteLine("Ingrese el elemento que sera parte de la matriz: ");
                    linea= Console.ReadLine();
                    matriz[f, c] = int.Parse(linea); 
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Mayor() {

            int mayor = matriz[0,0];
            int filam, colum;
            filam = 0; colum = 0;
                for (int f = 0; f < matriz.GetLength(0); f ++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    if (matriz[f,c] > mayor)
                    {
                        mayor = matriz[f,c];
                        filam = f;
                        colum = c;

                    }
                }
            }
            Console.WriteLine("El elemento mayor es: " + mayor + " y se encuentra en la fila: " + filam + " y en la columna: " + colum);
                }
        
static void Main(string[] args)
    {
            Matriz6 a1 = new Matriz6();
            a1.Carga();
            a1.Imprimir();
            a1.Mayor();
        
            
            
            */

    /*          
    class Matriz7 {

        private int[,] mat;

        public void Carga() {

            Console.WriteLine("Ingrese cuantas filas tendra la matriz: ");
            int filas, columnas;
            string linea;
            linea = Console.ReadLine();
            filas = int.Parse(linea);

            Console.WriteLine("Ingrese cuantas columnas tendra la matriz: ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            mat = new int[filas, columnas];

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese un elemento: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }

            }
        }

        public void ImprimirMayor()
        {
            int mayor = mat[0, 0];
            int ColMayor = 0;
            int FilMayor = 0;

            for (int f = 0;f < mat.GetLength(0); f++)
            {
                for (int c = 0;c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] > mayor)
                    {
                        mayor = mat[f, c];
                        ColMayor = c;
                        FilMayor = f;
                    }
                }
            }
            Console.WriteLine("El mayor numero ingresado es: " + mayor + " se encuentra en la columna: " + ColMayor + " y en la fila: " + FilMayor);
        }
        static void Main(string[] args) { 
            Matriz7 mat = new Matriz7();
            mat.Carga();
            mat.ImprimirMayor();
    */

    /*

    class Matriz8 {

        private int[,] mat;

        public void Carga() {

            Console.WriteLine("Ingrese cuantas filas tendra la matriz: ");
            int filas, columnas;
            string linea;
            linea = Console.ReadLine();
            filas = int.Parse(linea);

            Console.WriteLine("Ingrese cuantas columnas tendra la matriz: ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            mat = new int[filas, columnas];

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese un elemento: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }

            }
        }

        public void Imprimir()
        {
            Console.WriteLine();
            for (int f = 0;f < mat.GetLength(0); f++)
            {
                for (int c = 0;c < mat.GetLength(1); c++)
                {
                    Console.Write(" | " + mat[f, c] + " ");
                    Console.Write(" " + f + " " + c);
                }
                Console.WriteLine();
            }
        }

        public void Intercambio()
        {
            for (int c = 0; c< mat.GetLength(0); c++)
            {
                int aux;
                aux = mat[0, c];
                mat[0, c] = mat[1,c];
                mat[1,c] = aux;

            }
        }

        public void Imprimir2()
        {
            Console.WriteLine();
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(" | " + mat[f, c] + " ");
                    Console.Write(" " + f + " " + c);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {

            Matriz8 a = new Matriz8();
            a.Carga();
            a.Imprimir();
            a.Intercambio();
            a.Imprimir2();

            */

    /*
    class Matriz9
    {

        private int[,] mat;
        private string linea;

        public void Carga()
        {
            int f, c, f1, c1;
            Console.WriteLine("Por favor ingrese el numero de filas que tendra la matriz");
            linea = Console.ReadLine();
            f1 = int.Parse(linea);
            Console.WriteLine("Por favor ingrese el numero de columnas que tendra la matriz");
            linea = Console.ReadLine();
            c1 = int.Parse(linea);

            mat = new int[f1, c1];

            for (f = 0; f < mat.GetLength(0); f++)
            {
                for (c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese elemento que compone la matriz: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
        
                public void Intercambio()
                {
            int f0;
                  
                        for (int c = 0; c < mat.GetLength(1); c++)
                        {
                            f0 = mat[0, c];
                            mat[0, c] = mat[1, c];
                            mat[1, c] = f0;
                        }                    
                }
            
       /* public void Intercambio()
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                int aux = mat[0, c];
                mat[0, c] = mat[1, c];
                mat[1, c] = aux;
            }
        }
       
    public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        
        static void Main(string[] args) {

            Matriz9 mat = new Matriz9();
            mat.Carga();
            mat.Intercambio();
            mat.Imprimir();
           
            
             
             */
            
            class Matriz10
    {
        private int[,] mat;
        string linea;

        public void Carga()
        {
            Console.WriteLine();
        }

    static void Main(string[] args) { 
            
            Console.ReadKey();
            
        }
    }
}



