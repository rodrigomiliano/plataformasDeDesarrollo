using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(1, 2));
            Console.WriteLine(calculadora.Restar(5, 1));
            Console.WriteLine(calculadora.Multiplicar(3, 3));
            Console.WriteLine(calculadora.Dividir(10, 2));

            CalculadoraCientifica cientifica = new CalculadoraCientifica();


            //cientifica.Potencia();

            //Calculadora calculadora1 = new Calculadora(1,2);
            //Calculadora calculadora2;

            //calculadora2 = new Calculadora();

            //calculadora.Numero1 = 10;
            //Console.WriteLine(calculadora.Numero1);

            //calculadora.Numero1 = 32;
            //Console.WriteLine(calculadora.Numero2);

            //calculadora.Metodo(1);
            //calculadora.Metodo(1,2);
            ////calculadora.Metodo();
            //calculadora = null;

        }
    }
}
