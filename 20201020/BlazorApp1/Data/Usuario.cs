﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Usuario
    {
        public int UsuarioPK { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }


        public Usuario() { }
        public Usuario(int UsuarioPK, string Nombre, string Clave)
        {
            this.UsuarioPK = UsuarioPK;
            this.Nombre = Nombre;
            this.Clave = Clave;            
        }
    }
}