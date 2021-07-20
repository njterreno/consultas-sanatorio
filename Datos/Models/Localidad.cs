using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class Localidad
    {
        public int CodPos { get; set; }
        public int SubCodPos { get; set; }
        public string Nombre { get; set; }
        public int IDProvincia { get; set; }
    }
}
