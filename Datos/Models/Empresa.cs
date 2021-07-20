using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Datos.Models
{
    public class Empresa
    {
        public int IDEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Piso { get; set; }
        public string Depto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int CodPos { get; set; }
        public int SubCodPos { get; set; }
        public int IDIVA { get; set; }
        public string CUIT { get; set; }
        public int DGR { get; set; }
        public string DGRNro { get; set; }
        public int IDGanancia { get; set; }
        public string GananciaNro { get; set; }
        public int AgenteRetencion { get; set; }
        public int Activa { get; set; }
        public byte Logo { get; set; } //ver qué tipo de variable usar
        public string LogoUbicacion { get; set; }
        public DateTime FechaIniAct { get; set; }
    
    }
}
