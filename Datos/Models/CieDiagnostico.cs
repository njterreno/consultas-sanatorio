using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class CieDiagnostico
    {
        public string IDDiagnostico { get; set; }
        public int IDCapitulo { get; set; }
        public int IDDivision { get; set; }
        public string Nombre { get; set; }
        public int Notifica { get; set; }
    }
}
