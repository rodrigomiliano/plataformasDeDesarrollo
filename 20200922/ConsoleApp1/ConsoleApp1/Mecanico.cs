using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
public class Mecanico
    {
        public void Arreglar(IRepuesto repuesto)
        {
            Console.WriteLine(repuesto.Precio);
        }
    }
}
