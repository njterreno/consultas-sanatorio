using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public interface IProveedorDeDatosEspecialidad
    {
        IEnumerable<Models.Especialidad> Get();
    }
}
