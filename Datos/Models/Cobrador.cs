using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public class Cobrador
    {
        public int IDCobrador { get; set;}
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Piso { get; set; }
        public string Depto { get; set; }
        public int CodPos { get; set; }
        public int SubCodPos { get; set; }
        public int IDIVA { get; set; }
        public string CUIT { get; set; }
        public int IDGanancia { get; set; }
        public string GananciaNro { get; set; }
        public int IDDGR { get; set; }
        public string DGRNro { get; set; }
        public int PorcVenta { get; set; }
        public int PorcCobro { get; set; }
        public int Codigo { get; set; }
        public int IDEmpresa { get; set; }
    }
}
