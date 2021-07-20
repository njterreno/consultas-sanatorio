using System;

namespace Datos.Models
{
    public class Medico
    {
        public int IDMedico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IDDocumento { get; set; }
        public int NroDoc { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Sexo { get; set; }
        public string MatriculaEsp { get; set; }
        public DateTime FechaMatEsp { get; set; }
        public string MatriculaProf { get; set; }
        public DateTime FechaMatProf { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Piso { get; set; }
        public string Depto { get; set; }
        public int CodPos { get; set; }
        public int SubCodPos { get; set; }
        public int IDEspecialidad { get; set; }
        public int Prestador { get; set; }
        public int IDIVA { get; set; }
        public string CUIT { get; set; }
        public int IDGanancia { get; set; }
        public string GananciaNro { get; set; }
        public int IDDGR { get; set; }
        public string DGRNro { get; set; }
        public DateTime FechaNac { get; set; }
        public string SisTurno { get; set; }
        public string NombreRed { get; set; }
        public int IDEspecialidad2 { get; set; }
        public string MatriculaEsp2 { get; set; }
        public DateTime FechaMatEsp2 { get; set; }
        public int Categoria { get; set; }
        public int Activo { get; set; }
        public int IrregularidadAfip { get; set; }
        public int IDVendedor { get; set; }
        public int IDZona { get; set; }
        public int IDCobrador { get; set; }
        public int Empresa { get; set; }
        public int Codigo { get; set; }
        public int Admision { get; set; }
        public int MEntrada { get; set; }
        public int Facturacion { get; set; }
        public int Farmacia { get; set; }
        public int CtaCte { get; set; }
        public string Comentario { get; set; }
        public int Laboratorio { get; set; }
        public int HabilitaCtaCte { get; set; }
        public int MontoMaxCtaCte { get; set; }
        public int DiasVtoCtaCte { get; set; }
        public int FactCompVen { get; set; }
        public int DaTurno { get; set; }
        public int DocumentoAfip { get; set; }
        public int HabilitadoWeb { get; set; }
    }
}