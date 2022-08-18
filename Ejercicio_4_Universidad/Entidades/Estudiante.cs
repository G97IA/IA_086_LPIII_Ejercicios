using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Estudiante
    {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public string Carrera { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[] Fotografia { get; set; }

    }
}
