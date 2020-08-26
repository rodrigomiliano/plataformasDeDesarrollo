using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        /*{
            Console.WriteLine("Baraja tematica clasica para batalla");
                    
            int carta = 12;
            string mensaje;
            string valor = Console.ReadLine();
            carta = int.Parse(valor);
            if (carta <= 12 && carta >= 10 )
            {
                mensaje = "Tenes numeros de 2 cifras, los mas altos. Podes ganar la mayoria de batallas";
            }
            else if (carta == 9 || carta == 8)
            {
                mensaje = "Sacaste numeros altos, te pueden servir en varias batallas";
            }
            else if (carta >= 4 && carta <= 7)
            {
                mensaje = "Numeros medios, cuidado cuando los uses";
            }
            else if (carta < 4)
            { 
                mensaje = "Tenes numeros muy bajos, dificil de ganar con esto";
            }
            else
            {
                mensaje = "Por favor elija numeros entre 1 y 12";
            }
            Console.WriteLine(mensaje);
        }*/
        {
            /*
            Console.WriteLine("sumando hasta 50");

            int posicion = 5;
            string mensaje;
            string valor = Console.ReadLine();
            posicion = int.Parse(valor);

            for (int posicion = 10; posicion < 20; posicion++)
            {
                if (posicion == 15)
                {
                    break;
                }
            }*/

            string mensaje = "Ingrese un numero";
            int contador = 0;



            for (int posicion = 0; posicion < 10; posicion++)
            {
                Console.WriteLine(mensaje);
                string valor2 = Console.ReadLine();
                int numero = int.Parse(valor2);
                contador = contador + numero;

                if (contador > 50)
                {
                    Console.WriteLine("El total acumulado fue " + contador);
                    break;
                }
            }




        }  
    } 
}
