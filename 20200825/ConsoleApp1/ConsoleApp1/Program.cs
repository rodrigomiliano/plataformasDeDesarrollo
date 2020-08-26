using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int intentos = 0;
            //string clave = "";
            //while (clave != "secreto" & intentos < 4)                            
            //{
            //    Console.Write("Ingrese la constrasena: ");
            //    clave = Console.ReadLine();
            //    intentos++;
            //}

            //do
            //{
            //    Console.WriteLine(numero);
            //} while (numero < 10);


            //Console.WriteLine("Hola Mundo!");


           
            int numeroSecreto = 8;
            int numeroApostado = 0;

            while (numeroSecreto != numeroApostado)
            {
                Console.WriteLine("Adivina el numero: elige entre 0 y 9");
                numeroApostado = int.Parse(Console.ReadLine());                
                if (numeroSecreto != numeroApostado)
                {
                    Console.Write("Incorrecto, segui intentando.");                    
                }
                else
                {
                    Console.WriteLine("Ganaste: el numero era " + numeroSecreto);
                }

            }
            


        }
    }
}
