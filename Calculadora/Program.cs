/*Author: Fran Espino Mostacero
  Description: Calculator basic in c# using the casting
 */
using System;
using System.Threading; //To use the Thread.Sleep(miliseconds);
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            int sum,subtraction, multiplication,division;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t***************************");
                Console.WriteLine("\t\t\t\tMENU");
                Console.WriteLine("\t\t1.Suma");
                Console.WriteLine("\t\t2.Resta");
                Console.WriteLine("\t\t3.Multiplicacion");
                Console.WriteLine("\t\t4.Division");
                Console.WriteLine("\t\t5.Salir");
                Console.WriteLine("\t\t***************************");
                Console.WriteLine("Ingrese una opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor de a: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de a: ");
                        b = float.Parse(Console.ReadLine());
                        //we perform the explicit conversion (Casting) / realizamos una conversion explicita Casting
                        sum = (int)(a + b);
                        Console.WriteLine("Respuesta: "+sum);
                        //two seconds to visualize the result / dos segundos para visualizar el resultado
                        Thread.Sleep(2000);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor de a: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de a: ");
                        b = float.Parse(Console.ReadLine());
                        subtraction = (int)(a - b);
                        Console.WriteLine("Respuesta: "+ subtraction);
                        Thread.Sleep(2000);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor de a: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de a: ");
                        b = float.Parse(Console.ReadLine());
                        multiplication = (int)(a * b);
                        Console.WriteLine("Respuesta: " + multiplication);
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor de a: ");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor de a: ");
                        b = float.Parse(Console.ReadLine());
                        division = (int)(a / b);
                        Console.WriteLine("Respuesta: " + division);
                        Thread.Sleep(2000);
                        break;
                }

            } while (op != 5);

        }
    }
}
