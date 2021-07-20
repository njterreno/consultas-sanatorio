using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class Documento
    {
        public int IDDocumento { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public int Mostrar { get; set; }
    }
}
