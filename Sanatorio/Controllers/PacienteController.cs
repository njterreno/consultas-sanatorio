using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos.ProveedorDeDatos;
using Datos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sanatorio.Controllers
{
    [Produces("application/json")]

    //[Route("api/paciente")]

    [Route("paciente")]

    public class PacienteController : Controller
    {
        private readonly IProveedorDeDatosPaciente proovedorDeDatosPaciente;

        public PacienteController(IProveedorDeDatosPaciente proovedorDeDatosPaciente)
        {
            this.proovedorDeDatosPaciente = proovedorDeDatosPaciente;
        }

        //GET: api/ControladorPaciente
        //[HttpGet]

        [Route("consultar"), HttpGet]
        public async Task<IEnumerable<Paciente>> Consultar()
        {
            return await this.proovedorDeDatosPaciente.ConsultarPacientes();
        }

        //GET: api/ControladorPaciente/5
        [HttpGet("{DNI}")]
        public async Task<Paciente> Consultar(int DNI)
        {
            return await this.proovedorDeDatosPaciente.ConsultarPaciente(DNI);
        }        

        //POST: api/ControladorPaciente
        //[Route("agregar"), HttpPost]
        [HttpPost]
        public async Task Post([FromBody]Paciente paciente)
        {
            await this.proovedorDeDatosPaciente.AgregarPaciente(paciente);
        }

        //[HttpPost]
        //public async Task Post([FromBody]User user)
        //{
        //    await this.userDataProvider.AddUser(user);
        //}

        //PUT: api/ControladorPaciente/5
        [HttpPut("{DNI}")]
        public async Task Put(int DNI, [FromBody]Paciente paciente)
        {
            paciente.NroDoc = DNI;
            await this.proovedorDeDatosPaciente.ActualizarPaciente(paciente);
        }

        //[HttpPut("{UserId}")]
        //public async Task Put(string UserId, [FromBody]User user)
        //{
        //    await this.userDataProvider.UpdateUser(user);
        //}

        //DELETE: api/ApiWithActions/5
        [HttpDelete("{DNI}")]
        public async Task Delete(int DNI)
        {
            await this.proovedorDeDatosPaciente.BorrarPaciente(DNI);
        }

        //[HttpDelete("{UserId}")]
        //public async Task Delete(string UserId)
        //{
        //    await this.userDataProvider.DeleteUser(UserId);
        //}
    }
}
