using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDemo
{
    public class Contacto
    {
        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
