using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion_V1._3.Services.Interfaces
{
    public interface INavigationService
    {
        #region "Implementaciones"
        Task MostrarSnak( string mensaje);
        Task MostrarToast(string mensaje);
        Task Navegar(string pagina);
        Task Regresar();
        #endregion
    }
}
