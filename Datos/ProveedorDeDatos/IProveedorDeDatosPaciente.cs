using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;

namespace Datos.ProveedorDeDatos
{
    public interface IProveedorDeDatosPaciente
    {
        Task<IEnumerable<Paciente>> ConsultarPacientes();

        Task<Paciente> ConsultarPaciente(int DNI);

        Task AgregarPaciente(Paciente paciente);

        Task ActualizarPaciente(Paciente paciente);

        //Task BorrarPaciente(string IDPaciente);

        Task BorrarPaciente(int DNI);
    }
}
