using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 1
            /*
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero");
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
                if (numero == secreto) break;
            }
            if (numero == secreto)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste el numero era " + secreto);
            }
            */

            //EJERCICIO 2
            /*
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero");
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
                if (numero == secreto) break;
            }
            string mensaje;
            if (numero == secreto)
            {
                mensaje = Ganaste();                
            }
            else
            {
                mensaje = Perdiste(secreto);                
            }
            Console.WriteLine(mensaje);


            static string Ganaste()
            {
                string mensaje = "Ganaste";
                return mensaje;
            }

            static string Perdiste(int valor)
            {
                
                return "Perdiste el numero era " + valor ;
            }
            */

            //EJERCICIO 3
            /*
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                IngreseElNumero("Ingrese el numero: ", ref numero);
                if (numero == secreto) break;
            }
            string resultado;
            if (numero == secreto)
            {
                resultado = Ganaste();
            }
            else
            {
                resultado = Perdiste(secreto);
            }
            Console.WriteLine(resultado);

        
            static void IngreseElNumero(string mensaje, ref int numero)
            {
                Console.WriteLine(mensaje);
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
            }

            static string Ganaste()
            {
                string mensaje = "Ganaste";
                return mensaje;
            }

            static string Perdiste(int valor)
            {
                return "Perdiste el numero era " + valor;
            }
            */

            //EJERCICIO 4

            int anio;
            string mensaje = "Ingrese su año de nacimiento";
            IngresoAnio(mensaje, out anio);
            Console.WriteLine(EsAniobiciesto(anio));


        }
        static void IngresoAnio(string mensaje, out int anio)
        {
            Console.WriteLine(mensaje);
            anio = int.Parse(Console.ReadLine());
        }
        static string EsAniobiciesto(int anio)
        {
            if ((anio % 400 == 0))
            {
                return "Es año bisiesto";
            }
            if ((anio % 4 == 0) && (anio % 100 != 0))
            {
                return "Es año bisiesto";
            }
            else
            {
                return "No es año bisiesto";
            }



        }
    }
}
