using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public interface IProveedorDeDatosHistoriaClinica
    {
        IEnumerable<Models.HistoriaClinica> Get();
    }
}
