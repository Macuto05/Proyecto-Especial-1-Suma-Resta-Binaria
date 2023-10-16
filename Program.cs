using System;
using System.Drawing;

namespace Proyecto_Especial_1
{
    internal class Program
    { 
        static int ValidarNegativo(string msj)
        {
            int numpositivo;
            do
            {
                Console.Write(msj);
                numpositivo = int.Parse(Console.ReadLine());
                
                if(numpositivo < 0)
                {
                    Console.WriteLine("No se permiten numeros negativos");
                }
            }while(numpositivo < 0);

            return numpositivo;
        }

        static void Gracias()
        {
            Console.WriteLine("LISTO... GRACIAS POR USAR >:)");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            int num1, num2;
            int op;

            do
            {
                Console.WriteLine("Bienvenido a la calculadora de Numero Binario");

                Console.WriteLine("Ingrese el numero: ");

                Console.WriteLine("1 si desea cargar los numeros y ver su conversion a binario");

                Console.WriteLine("2 si desea sumar los numeros en binario");

                Console.WriteLine("3 si desea restar los numeros en binario");

                Console.WriteLine("0 si desea salir");

                Console.Write("Opcion: "); op = int.Parse(Console.ReadLine());

                switch (op) {

                        case 1: 

                        Console.Clear();

                        num1 = ValidarNegativo("Ingrese el primer numero a transfromar: "); 
                        
                        num2 = ValidarNegativo("Ingrese el segundo numero a transfromar: ");

                        Binario objBinario = new Binario(num1, num2);
                        objBinario.mostrarBinario();

                        Gracias();

                        break;

                        case 2:

                        Console.Clear();

                        num1 = ValidarNegativo("Ingrese el primer numero a transfromar: "); 

                        num2 = ValidarNegativo("Ingrese el segundo numero a transfromar: ");

                        objBinario = new Binario(num1, num2);

                        objBinario.mostrarBinario();

                        Console.WriteLine();

                        objBinario.mostrarSumaBinaria();

                        Gracias();

                        break; 

                        case 3:

                        Console.Clear();

                        num1 = ValidarNegativo("Ingrese el primer numero a transfromar: ");

                        num2 = ValidarNegativo("Ingrese el segundo numero a transfromar: ");

                        objBinario = new Binario(num1, num2);

                        objBinario.mostrarBinario();

                        Console.WriteLine();

                        objBinario.mostrarRestaBinaria();

                        Gracias();

                        break;

                    case 0:
                        Console.WriteLine("GRACIAS POR USAR  >:)");
                        break; 

                        default: 
                        Console.WriteLine("NUMERO INVALIDO");
                        Console.WriteLine("VUELVA A INGRESAR LA OPCION");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (op != 0);

            Console.ReadKey();
        }
    }
}
