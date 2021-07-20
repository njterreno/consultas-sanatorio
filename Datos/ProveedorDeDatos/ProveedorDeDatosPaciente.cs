using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;
using Datos.Models;

namespace Datos.ProveedorDeDatos
{
    public class ProveedorDeDatosPaciente : IProveedorDeDatosPaciente
    {
        private readonly string connectionString = "Data Source = SERVIDORVBS2; Initial Catalog = DBClinicaPosse; Persist Security Info=True; User ID = sa; Password=VBS2470";

        //consultar todos los pacientes
        public async Task<IEnumerable<Paciente>> ConsultarPacientes()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                string stSQL = "select nombre, apellido, nrodoc from paciente";//"select nombre + '  ' + apellido as Paciente, nrodoc as DNI from PACIENTE";
                return await sqlConnection.QueryAsync<Paciente>(stSQL);

                //("select nombre, apellido from paciente");
            }
        }


        //filtrar paciente por nombre
        public async Task<Paciente> ConsultarPaciente(int DNI)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                string stSQL = "select nombre, apellido, nrodoc from paciente where nrodoc =" + DNI + "";
                return await sqlConnection.QuerySingleOrDefaultAsync<Paciente>(stSQL);
            }
        }

        public async Task AgregarPaciente(Paciente paciente)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                string stSQL = "select ISNULL(MAX(PACIENTE),0) from PACIENTE";
                int IDPacienteMax = await sqlConnection.QuerySingleOrDefaultAsync<int>(stSQL);
                int IDPacienteNvo = IDPacienteMax + 1;

                await sqlConnection.ExecuteAsync(" IF EXISTS (select * from tempdb..sysobjects where id = object_id('tempdb..#TmpConeccion')) DROP TABLE tempdb..#TmpConeccion");

                await sqlConnection.ExecuteAsync(" CREATE TABLE #TmpConeccion(ID INT NOT NULL,USUARIO VARCHAR(60) NOT NULL,EQUIPO VARCHAR(60) NOT NULL)");

                await sqlConnection.ExecuteAsync(" INSERT Into #TmpConeccion (ID,USUARIO,EQUIPO) Select @@Spid as ID,'A' AS USUARIO,'SERVIDOR' AS EQUIPO");

                await sqlConnection.ExecuteAsync(" insert into paciente(paciente, nombre, apellido, nrodoc, empresa, codigo) values ( " + IDPacienteNvo + " , '" + paciente.Nombre + "', '" + paciente.Apellido + "'," + paciente.NroDoc + " , " + paciente.IDEmpresa + " , " + IDPacienteNvo + ")");

                await sqlConnection.ExecuteAsync(" DROP TABLE #TmpConeccion");

                
            }

        }

        ////agregar usuario
        //public async Task AddUser(User user)
        //{
        //    using (var sqlConnection = new SqlConnection(connectionstring))
        //    {
        //        await sqlConnection.OpenAsync();
        //        string stSQL = "insert into usuarios(login, clave) values ( '" + user.Login + "', '" + user.Clave + "')";
        //        await sqlConnection.ExecuteAsync(stSQL);
        //    }
        //}

        public async Task ActualizarPaciente(Paciente paciente)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                //string stSQL = "Update paciente set nombre =  '" + paciente.Nombre + "', apellido ='" +  paciente.Apellido + "' where NroDoc =" + paciente.NroDoc + "";
                //await sqlConnection.ExecuteAsync(stSQL);

                await sqlConnection.ExecuteAsync(" IF EXISTS (select * from tempdb..sysobjects where id = object_id('tempdb..#TmpConeccion')) DROP TABLE tempdb..#TmpConeccion");

                await sqlConnection.ExecuteAsync(" CREATE TABLE #TmpConeccion(ID INT NOT NULL,USUARIO VARCHAR(60) NOT NULL,EQUIPO VARCHAR(60) NOT NULL)");

                await sqlConnection.ExecuteAsync(" INSERT Into #TmpConeccion (ID,USUARIO,EQUIPO) Select @@Spid as ID,'A' AS USUARIO,'SERVIDOR' AS EQUIPO");

                await sqlConnection.ExecuteAsync(" Update paciente set nombre =  '" + paciente.Nombre + "', apellido ='" + paciente.Apellido + "' where NroDoc =" + paciente.NroDoc + "");

                await sqlConnection.ExecuteAsync(" DROP TABLE #TmpConeccion");
            }
        }

        ////ACTUALIZAR USUARIO
        //public async Task UpdateUser(User user)
        //{
        //    using (var sqlConnection = new SqlConnection(connectionstring))
        //    {
        //        await sqlConnection.OpenAsync();
        //        string stSQL = "Update usuarios set clave=  '" + user.Clave + "' where login='" + user.Login + "'";
        //        await sqlConnection.ExecuteAsync(stSQL);
        //    }
        //}

        public async Task BorrarPaciente(int DNI)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                string stSQL = "Delete from paciente where NroDoc =" + DNI + "";
                await sqlConnection.ExecuteAsync(stSQL);
            }
        }

        ////ELIMINAR USUARIO
        //public async Task DeleteUser(string UserId)
        //{
        //            using (var sqlConnection = new SqlConnection(connectionstring))
        //            {
        //                await sqlConnection.OpenAsync();
        //                string stSQL = "Delete from usuarios where login ='" + UserId + "'";
        //                await sqlConnection.ExecuteAsync(stSQL);
        //            }
        //}

    }
}
