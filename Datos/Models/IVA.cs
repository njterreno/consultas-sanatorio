using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class IVA
    {
        public int IDIVA { get; set; }
        public string Nombre { get; set; }
        public int Porcentaje { get; set; }
        public int RecPorcen { get; set; }
        public string Reducido { get; set; }
    }
}
