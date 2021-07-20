using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public interface IProveedorDeDatosHCMedicacionActual
    {
        IEnumerable<Models.HCMedicacionActual> Get();
    }
}
