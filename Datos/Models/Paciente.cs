using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Models
{
    public partial class Paciente
    {

        public int IDPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Piso { get; set; }
        public string Depto { get; set; }
        public string Telefono { get; set; }
        public int IDDocumento { get; set; }
        public int NroDoc { get; set; }
        public int IDEstadoCivil { get; set; }
        public int IDMedico { get; set; }
        public int CodPos { get; set; }
        public int SubCodPos { get; set; }
        public int IDOcupacion { get; set; }
        public int IDIVA { get; set; }
        public string CUIT { get; set; }
        public int IDDGR { get; set; }
        public string DGRNro { get; set; }
        public int IDGanancia { get; set; }
        public string GananciaNro { get; set; }
        public int Activo { get; set; }
        public string Mail { get; set; }
        public int NroContrato { get; set; }
        public int IrregularidadAfip { get; set; }
        public int IDVendedor { get; set; }
        public int IDZona { get; set; }
        public int IDCobrador { get; set; }
        public int IDEmpresa { get; set; }
        public int Codigo { get; set; }
        public int Verificado { get; set; }
        public string OcupacionTxt { get; set; }
        public string Comentario { get; set; }
        public int HabilitaCtaCte { get; set; }
        public int MontoMaxCtaCte { get; set; }
        public int DiasVtoCtaCte { get; set; }
        public int FactCompVen { get; set; }
        public int DocumentoAfip { get; set; }
        public string Alias { get; set; }

        //public static int IDPacienteNvo(string stSQL1, int IDPacienteMax)
        //{
        //    int IDPacienteNvo = IDPacienteMax + 1;

        //    return IDPacienteNvo;
        //}

        //static public int IDPaciente(string newName, string connString)
        //{
        //    Int32 newProdID = 0;
        //    string sql =
        //        "INSERT INTO Production.ProductCategory (Name) VALUES (@Name); "
        //        + "SELECT CAST(scope_identity() AS int)";
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.Add("@Name", SqlDbType.VarChar);
        //        cmd.Parameters["@name"].Value = newName;
        //        try
        //        {
        //            conn.Open();
        //            newProdID = (Int32)cmd.ExecuteScalar();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //    return (int)newProdID;
        //}

    }
}
