using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    /*
    internal class Triangulo
    {
        private int l1, l2, l3;

        public void Inicializar()
        {
            String linea;
            Console.WriteLine("Ingrese LADO 1 del triangulo: ");
            linea = Console.ReadLine();
            l1 = int.Parse(linea);

            Console.WriteLine("Ingrese LADO 2 del triangulo: ");
            linea = Console.ReadLine();
            l2 = int.Parse(linea);

            Console.WriteLine("Ingrese LADO 3 del triangulo: ");
            linea = Console.ReadLine();
            l3 = int.Parse(linea);
        }
        public void ImprimirMayor()
        {
            if (l1 > l2 && l1 > l3) {
                Console.WriteLine("El lado mayor es el 1: " + l1);
            } else {
                if (l2> l3)
                {
                    Console.WriteLine("El lado mayor es el 2: " + l2);
                } else { 
                //if (l3 > l1 && l3 > l2)
                
                    Console.WriteLine("El lado mayor es el 3: " + l3);
                
                }
            }
        }

        public void Equilatero()
        {
            if (l1 == l2 && l1 == l3)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else
            {
                Console.Write("No es un triángulo equilátero");
            }
        }
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Inicializar();
            triangulo.ImprimirMayor();
            triangulo.Equilatero();
    */

    /*
    internal class Problema3
    {
        private int x, y;
        public void Inicializador()
        {
            String linea;
            Console.WriteLine("Ingrese un eje X: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.WriteLine("Ingrese un eje Y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void MostrarCuadrante()
        {
            if(x > 0 && y > 0)
            {
                Console.WriteLine("Los puntos indicados se encuentran en el Cuadrante 1: " + "X " + x + " Y " + y);
            } else
            {
                if (x< 0 && y > 0) {
                    Console.WriteLine("Los puntos indicados se encuentran en el Cuadrante 2: " + "X " + x + " Y " + y);
                } else
                {
                    if(x< 0 && y < 0)
                    {
                        Console.WriteLine("Los puntos indicados se encuentran en el Cuadrante 3: " + "X " + x + " Y " + y);
                    } else { Console.WriteLine("Los puntos indicados se encuentran en el Cuadrante 4: " + "X " + x + " Y " + y); }
                }
            }
        }
        static void Main(string[] args)
        { 
            Problema3  p1= new Problema3();
            p1.Inicializador();
            p1.MostrarCuadrante();

    */

    /*
    internal class Cuadrado
    {
        private double lado,per,sup;
        public void Inicializar()
        {
            String linea;
            Console.WriteLine("Bienvenido :D");
                Console.WriteLine("Ingrese un lado del cuadrado");
                linea = Console.ReadLine();
                lado = double.Parse(linea);
        }

        public void PerYSup()
        {
            per = lado * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + per);
            sup = lado * lado;
            Console.WriteLine("La superficie del cuadrado es: " + sup);
        }
    static void Main(string[] args)
        { 
            Cuadrado p1 = new Cuadrado();
            p1.Inicializar();
            p1.PerYSup();
            Cuadrado p2= new Cuadrado();
            p2.Inicializar();
            p2.PerYSup();
            Cuadrado p3 = new Cuadrado();
            p3.Inicializar();
            p3.PerYSup();
            Cuadrado p4 = new Cuadrado();
            p4.Inicializar();
            p4.PerYSup();


    */

    /*
    internal class Sueldos
    {
        private float sueldo;
        private String nombre;
        public void Empleado()
        {
            String linea;
            Console.WriteLine("Empleado por favor le solicitamos ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Le solicitamos ingrese su sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }
        public void Datos()
        { 
            Console.Write("El nombre del empleado es: " + nombre);
            Console.Write(" y su sueldo es: " + sueldo + ". ");
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El emplead@ de nombre: " + nombre + " debe pagar impuestos ya que su sueldo (" + sueldo + ")" + " es mayor a 3000");
            }
        }
    static void Main(string[] args)
        { 
            Sueldos p1= new Sueldos();
            p1.Empleado();
            p1.Datos();
            p1.Impuestos();

            */
     
    internal class Operaciones
    {
        private int num1,num2,suma,resta,multiplicacion,division;
        public void Inicializar ()
        {
            String linea;
            Console.WriteLine("Ingrese un numero entero: ");
            linea = Console.ReadLine();
            num1= int.Parse(linea);

            Console.WriteLine("Ingrese otro numero entero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }

        public void Suma()
        {
            suma = num1 + num2;
            Console.WriteLine("Total de la suma: " + suma);
        }

        public void Resta()
        {
            if (num1 > num2)
            {
                resta = num1 - num2;
                Console.WriteLine("Total de la resta: " + resta);
            } else
            {
                resta = num2 - num1;
                Console.WriteLine("Total de la resta: " + resta);
            }
        }
        public void Multiplicacion()
        {
            multiplicacion = num1 * num2;
            Console.WriteLine("Total de la multiplicacion: " + multiplicacion);
        }
        public void Division()
        {
            if (num1 > num2)
            {
                division = num1 / num2;
                Console.WriteLine("Total de la division: " + division);
            }
            else
            {
                division = num2 - num1;
                Console.WriteLine("Total de la resta: " + resta);
            }
           
        }

        static void Main(string[] args)
    {
            Operaciones p1= new Operaciones();
            p1.Inicializar();
            p1.Suma();
            p1.Resta();
            p1.Multiplicacion();
            p1.Division();
    
        Console.ReadKey();
        }
    }
}
