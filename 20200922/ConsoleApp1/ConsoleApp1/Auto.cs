using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Auto : Vehiculo
    {
        public int cantPuertas { get; set; }
        protected override void Detener()
        {
            throw new NotImplementedException();
        }
    }
}
