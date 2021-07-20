using System;
using System.Collections.Generic;
using System.Text;


namespace Datos.Models
{
    public class HistoriaClinica
    {
        public int IDHistoriaClinica { get; set; }
        public int Paciente { get; set; }
        public int Medico { get; set; }
        public DateTime Fecha { get; set; }
        public int IDHCTipo { get; set; }
        public string IDDiagnostico { get; set; }
        public string DiagnosticoDes { get; set; }
        public string CieDiagnostico { get; set; }
        public string Detalle1 { get; set; }
        public string Detalle2 { get; set; }
        public string Detalle3 { get; set; }
        public string Observacion { get; set; }
        public string SectorDes { get; set; }
    }
}