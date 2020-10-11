using System;

namespace ConsoleApp1
{
    public class Usuario
    {
        
        public int UsuarioPK { get; set; }
        public int Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario(string usuario, string clave)
        {
        }
    }
}

