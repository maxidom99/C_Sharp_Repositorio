using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileForStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE 5

            /*  int x,n,sueldo,gastos,emp1,emp2;
              string linea;
              x = 1;
              gastos = 0;
              emp1 = 0;
              emp2 = 0;

              Console.WriteLine("Ingrese cuantos empleados tiene la empresa: ");
              linea = Console.ReadLine();
              n = int.Parse(linea);

              while (x <= n)
              {
                  Console.WriteLine("Ingrese el sueldo del empleado: ");
                  linea = Console.ReadLine();
                  sueldo = int.Parse(linea);

                  if (sueldo <= 300)
                  {
                      emp1 = emp1 + 1;
                  } else { emp2 = emp2 + 1;
              }
              gastos = gastos + sueldo;
                  x = x + 1;
  }
              Console.WriteLine("La cantidad de empleados con un sueldo entre $100 y $300 son: " + emp1);
              Console.WriteLine("La cantidad de empleados con un sueldo mayor a $300 son: " + emp2);
              Console.WriteLine("Los gastos de la empresa en relacion a los sueldos que paga son: " + gastos);*/

            //WHILE 6 

            /* int x,lista1,lista2,num1,num2;
             string linea;
             x = 1;
             lista1=0; lista2=0;

             Console.WriteLine("Inicio programa :D");

             while ( x < 4 ) {

                 Console.Write("Ingrese un numero para guardar en la primer lista: ");
                 linea = Console.ReadLine();
                 num1 = int.Parse(linea);
                 lista1 = lista1 + num1;
                 x = x + 1;
             }
             Console.WriteLine("Valor de la primer lista: " + lista1);

             x = 1;

            while ( x < 4 )
             {

                 Console.Write("Ingrese un numero para guardar en la segunda lista: ");
                 linea = Console.ReadLine();
                 num2 = int.Parse(linea);
                 lista2 = lista2 + num2;
                x = x + 1;
             }
             Console.WriteLine("Valor de la segunda lista: " + lista2);

             if ( lista1 > lista2 ) {
             Console.WriteLine("La LISTA 1 tiene mayor valor: " +lista1);
             } 
                  else { 
             }            if (lista1 < lista2)            
             {
                 Console.WriteLine("La LISTA 2 tiene mayor valor: " + lista2);

             } else { Console.WriteLine("Las listas son iguales " + lista1 + " - " + lista2); }



 */
            /*
                        int n, x, num,par,impar;
                        string linea;
                        par = 0; impar= 0;
                            x = 1;

                        Console.WriteLine("Inicia el programa :D");
                        Console.WriteLine("Ingrese el numero de valores que va a ingresar: ");
                        linea = Console.ReadLine();
                        n = int.Parse(linea);

                        while (x <= n)
                        {

                            Console.WriteLine("Ingrese numeros: ");
                            linea= Console.ReadLine();
                            num= int.Parse(linea);

                            if (num % 2 == 0) {         //Si el if da verdadero luego es par.

                                par = par + 1;
                            } else { impar = impar + 1; }

                            x = x + 1;
                        }
                        Console.WriteLine("Usted ingreso " + par + " numeros pares y " + impar + " numeros impares.");


            */

            /*
             
            int suma, valor;
            suma = 0;
            string linea;

            for (int x = 1; x <= 3; x++)
            {
                Console.WriteLine("Numero: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;
            }
            int promedio;
            promedio = suma / 10;
            Console.WriteLine(suma);
            Console.WriteLine(promedio);
*/


            /*
            int m3, m5, x,num;
            m3 = 0; m5 = 0;
            string linea;
            for (x = 1; x <= 4; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if ((num%3)== 0) {
                    m3 = m3 + 1;
                } if ((num%5)== 0) { 
                    m5= m5 + 1;
                }
            }  
            Console.WriteLine("Ha ingresado " + m3 + " multiplos del numero 3");
            Console.WriteLine("Ha ingresado " + m5 + " multiplos del numero 5");

            */


            /*
                        int cant,n,x,sup,b,h;
                        cant = 0;
                        string linea;

                        Console.WriteLine("Cuantos nums va a ingresar? ");
                        linea = Console.ReadLine();
                        n = int.Parse(linea);

                        for (x = 1; x <= n; x ++ )
                        {
                            Console.WriteLine("Ingrese cuanto mide la base del triangulo: ");
                            linea = Console.ReadLine() ;
                            b = int.Parse(linea);

                            Console.WriteLine("La ultima base ingresada mide: " + b);

                            Console.WriteLine("Ingrese cuanto mide la altura del triangulo: ");
                            linea = Console.ReadLine();
                            h = int.Parse(linea);

                            Console.WriteLine("La ultima altura ingresada mide: " + h);

                            sup = (b * h) / 2;
                            Console.WriteLine("La ultima superfice calculada es de: " + sup);

                            if ( sup > 12 ) {
                            cant = cant + 1;
                            }

                        }
                        Console.WriteLine("Usted ingreso " + cant + " triangulos con una superficie > a 12");

                        */


            /*
            int x, num, suma;
            suma = 0;
            string linea;

            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("Ingrese num: ");
                linea = Console.ReadLine();

                num = int.Parse(linea);

                if (x > 5)
                {

                    //Console.WriteLine("Usted ingreso el siguiente num: " + num);
                    suma = suma + num;
                }

            }
            Console.WriteLine("la suma de los ult 5 vals es: " + suma);


            */


            /*
            int x, mult, n;
            mult = 0;
            string linea;

            Console.WriteLine("Ingrese un valor del 1 al 10: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            if ( n <= 10 && n <= 1) {
                
            } else
            { Console.WriteLine("Ingreso un num incorrecto salame"); }

            for(x = 1;x <= 13; x++ )
            {
                mult = n * x;
                Console.WriteLine(mult);
            }
            
            */

            /* FOR TRIANGULOS !!
                        int x, n, equi, iso, esca, l1, l2, l3;
                        equi = 0;
                        iso = 0;
                        esca = 0;
                        string linea;

                        Console.WriteLine("Ingrese cuantos triangulos quiere consultar: ");
                        linea = Console.ReadLine();
                        n = int.Parse(linea);

                        for (x = 1; x <= n; x++)
                        {

                            Console.WriteLine("Ingrese el primer lado del triangulo: ");
                            linea = Console.ReadLine();
                            l1 = int.Parse(linea);

                            Console.WriteLine("Ingrese el sgundo lado del triangulo: ");
                            linea = Console.ReadLine();
                            l2 = int.Parse(linea);

                            Console.WriteLine("Ingrese el tercer lado del triangulo: ");
                            linea = Console.ReadLine();
                            l3 = int.Parse(linea);


                            if (l1 == l2 && l1 == l3)
                            {

                                Console.WriteLine("Triangulo equilatero.");
                                equi++;
                            }
                            else
                            {
                                if (l1 == l2 || l2 == l1 || l2 == l3)
                                {
                                    Console.WriteLine("Triangulo isosceles.");
                                    iso++;

                                }
                                else
                                {
                                    Console.WriteLine("Triangulo escaleno.");
                                    esca++;
                                }
                            }
                        }

                        Console.WriteLine("Ingreso una cantidad de " + equi + " triangulos equilateros");
                        Console.WriteLine("Ingreso una cantidad de " + iso + " triangulos isosceles");
                        Console.WriteLine("Ingreso una cantidad de " + esca + " triangulos escalenos");

                        if (equi < iso && equi < esca)
                        {
                            Console.WriteLine("Triangulos equilateros tuvieron menos ingresos: " + equi);
                        }
                        else
                        {

                            if (iso < esca)
                            {

                                Console.WriteLine("Triangulos escalenos tuvieron menos ingresos: " + esca);
                            }
                            else
                            {
                                Console.WriteLine("Triangulos isosceles tuvieron menos ingresos: " + iso);
                            }




            }*/


            /*
             
            int f,n,x,y,cua1,cua2,cua3,cua4;
            cua1 = 0;
            cua2 = 0;
            cua3 = 0;
            cua4 = 0;
            string linea;

            Console.WriteLine("Ingrese cuantas coordenadas quiere ingresar en el plano: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (f = 1; f <= n; f++)
            {
                Console.WriteLine("Ingrese su punto 'X' en el plano: ");
                linea = Console.ReadLine();
                x = int.Parse(linea);

                Console.WriteLine("Ingrese su punto 'Y' en el plano: ");
                linea = Console.ReadLine();
                y = int.Parse(linea);

                if (x > 0 && y > 0) {
                    cua1++;
                } else {
                    if (x<0 && y > 0)
                    {
                        cua2++; 
                    } else
                    {
                        if (x< 0 && y < 0)
                        {
                            cua3++;
                        }
                        else
                        {
                            if ( x > 0 && y < 0)
                            {
                                cua4++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Usted ingreso " + cua1 + " par/es de coordenadas en el cuadrante 1 !");
            Console.WriteLine("Usted ingreso " + cua2 + " par/es de coordenadas en el cuadrante 2 !");
            Console.WriteLine("Usted ingreso " + cua3 + " par/es de coordenadas en el cuadrante 3 !");
            Console.WriteLine("Usted ingreso " + cua4 + " par/es de coordenadas en el cuadrante 4 !");


            */


            /*

            int f, edad, suma1, suma2, suma3, pro1, pro2, pro3;
            string linea;
            suma1 = 0;
            suma2 = 0;
            suma3 = 0;
            for (f = 1; f <= 50; f++)
            {
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                suma1 = suma1 + edad;
            }
            pro1 = suma1 / 50;
            Console.Write("Promedio de edades del turno mañana:");
            Console.WriteLine(pro1);
            for (f = 1; f <= 60; f++)
            {
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                suma2 = suma2 + edad;
            }
            pro2 = suma2 / 60;
            Console.Write("Promedio de edades del turno tarde:");
            Console.WriteLine(pro2);
            for (f = 1; f <= 110; f++)
            {
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                suma3 = suma3 + edad;
            }
            pro3 = suma3 / 110;
            Console.Write("Promedio de edades del turno noche:");
            Console.WriteLine(pro3);
            if (pro1 < pro2 && pro1 < pro3)
            {
                Console.Write("El turno mañana tiene un promedio menor de edades.");
            }
            else
            {
                if (pro2 < pro3)
                {
                    Console.Write("El turno tarde tiene un promedio menor de edades.");
                }
                else
                {
                    Console.Write("El turno noche tiene un promedio menor de edades.");
                }
            }


            */


            /*PRIMER DO WHILE*/

            /*
                int valor;
                string linea;

                do
                {
                    Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza):");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);
                    if (valor >= 100)
                    {
                        Console.WriteLine("Tiene 3 dígitos.");
                    }
                    else
                    {
                        if (valor >= 10)
                        {
                            Console.WriteLine("Tiene 2 dígitos.");
                        }
                        else
                        {
                            Console.WriteLine("Tiene 1 dígito.");
                        }
                    }
                } while (valor != 0);


            */
            /*
                        int num, suma, cantidad;
                        suma = 0;
                        cantidad = 0;
                        string linea;

                        Console.WriteLine("Bienvenido al inicio del programa, puede finalizarlo ingresando '0' :D");

                        do

                        {
                            Console.WriteLine("Ingrese un numero: ");
                            linea = Console.ReadLine();
                            num = int.Parse(linea);

                            if (num != 0) {

                                suma = suma + num;
                                cantidad = cantidad + 1;
                            }

                        }while (num != 0);
                        int promedio;
                            if (cantidad != 0)
                        {
                            promedio = suma / cantidad;
                            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
                        } else
                        {
                            Console.WriteLine("No ingreso ningun valor.");
                        }




                            */

            /*
             
             float kg1,kg2,kg3,peso;
            string linea;

            kg1 =0; kg2 =0; kg3 =0;

            Console.WriteLine("Bienvenido al inicio del programa, puede finalizarlo ingresando '0' :D");

            do
            {

                Console.WriteLine("Ingrese los KG de las piezas: ");
                linea = Console.ReadLine();
                peso = float.Parse(linea);

                if (peso > 10.2)
                {
                    kg1++;
                    Console.WriteLine("Su pieza tiene un peso mayor a 10,2 Kg");
                }
                else
                {
                    if (peso >= 9.8 && peso <= 10.2)
                    {
                        kg2++;
                        Console.WriteLine("Su pieza tiene un peso entre 9,8 Kg y 10,2 Kg");
                    }
                    else
                    {
                        if (peso > 0)
                        {
                            kg3++;
                            Console.WriteLine("Su pieza tiene un peso menor a 9,8 Kg");
                        }
                    }
                }
            } while (peso != 0);
            
            float total;
            total = kg1+kg2+kg3;
                Console.WriteLine("El total de piezas procesadas es de : " + total);
            Console.WriteLine("Piezas entre 9.8 Kg y 10.2 Kg: " + kg2);
            Console.WriteLine("Piezas con mayor kilaje que 10.2 Kg: " + kg1);
            Console.WriteLine("Piezas con menor kilaje que 9.8 Kg: " + kg3);
            Console.WriteLine("Slds...");
           
            */

            /*
            int num, total, cant;
            total = 0;
            string linea;
            cant = 0;  
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.WriteLine("Bienvenido :D Ingresando el numero 9999 finaliza.");

            do

            {
                Console.WriteLine("Ingresar valores que quiera sumar: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                total = total + num;
              
                cant++;

            } while (num != 9999);

            total = total - 9999;
            cant = cant - 1;

            if (total > 0)
            {
               
                Console.WriteLine("El valor sumado es mayor a cero: " + total);
            } else
            {
                if (total < 0)
                {
                    Console.WriteLine("El valor sumado es menor a cero: " + total);
                }
                else
                {
                    if (total == 0)
                    {
                        Console.WriteLine("El valor sumado es 0");
                    }
                }            
                }
            Console.WriteLine("Usted ha ingresado " + cant + " numeros");
           



            */


            /*
             
            //PROGRAMA DE CUENTAS BANCARIAS Y SALDOS ACTUALES: 
                        
            int nroc, sa, suma;
                        suma = 0;
                        string linea;

                        //Console.WriteLine("Bienvenido, para finalizar ingrese un numero de cuenta negativo.");

                        do
                        {

                            Console.WriteLine("Ingrese un numero de cuenta y el saldo actual de la misma: ");
                            linea = Console.ReadLine();
                            nroc = int.Parse(linea);

                            if (nroc >= 0)
                            {

                                Console.WriteLine("Ingrese el saldo actual de la misma: ");
                                linea = Console.ReadLine();
                                sa = int.Parse(linea);

                                if (sa == 0)
                                {
                                    Console.WriteLine("Estado de cuenta Nulo: " + " Nro. de cuenta: " + nroc + " Saldo Total: " + sa);

                                }
                                if (sa > 0)
                                {
                                    suma = suma + sa;
                                    Console.WriteLine("Estado de cuenta Acreedor: " + " Nro. de cuenta: " + nroc + " Saldo Total: " + sa);
                                }
                                {
                                    if (sa < 0)
                                    {

                                        Console.WriteLine("Estado de cuenta Deudor: " + " Nro. de cuenta: " + nroc + " Saldo Total: " + sa);
                                    }
                                }
                            }

                        } while (nroc >= 0);

                        Console.WriteLine("La suma de las cuentas acreedoras es: " + suma);
                        */


            /*
             // Iniciando Strings.

            String nombre1, nombre2;
            int edad1, edad2;
            String linea;

            Console.WriteLine("Ingrese el nombre: ");
            nombre1 = Console.ReadLine();

            Console.WriteLine("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad1 = int.Parse(linea);

            Console.WriteLine("Ingrese el nombre: ");
            nombre2 = Console.ReadLine();

            Console.WriteLine("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad2 = int.Parse(linea);

            Console.WriteLine("La persona mayor de edad es: ");

            if (edad1 > edad2)
            {
                Console.WriteLine(nombre1);
            } else
            {
                Console.WriteLine(nombre2);
            }
            */

            /*
             //Segundo problema con Strings

            String ap1,ap2;
            string linea;

            Console.WriteLine("Ingrese un apellido: ");
            ap1 = Console.ReadLine();

            Console.WriteLine("Ingrese otro apellido: ");
            ap2 = Console.ReadLine();

            if (ap1 != ap2)
            {
                Console.WriteLine("Los apellidos ingresados son distintos");
            } else 
            { 
                Console.WriteLine("Los apellidos ingresados son iguales");
            }
            */

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();

            }
        }
    }

    