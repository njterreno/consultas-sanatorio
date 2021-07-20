using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public interface IProveedorDeDatosMedico
    {
        IEnumerable<Models.Medico> Get();
    }
}
