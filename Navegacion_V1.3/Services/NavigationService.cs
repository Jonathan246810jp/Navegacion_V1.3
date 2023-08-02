using Navegacion_V1._3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion_V1._3.Services
{
    public class NavigationService : INavigationService
    {
        #region Metodos
        public Task MostrarSnak(Color color, string mensaje)
        {
            throw new NotImplementedException();
        }

        public Task MostrarSnak(string mensaje)
        {
            throw new NotImplementedException();
        }

        public Task MostrarToast(string mensaje)
        {
            throw new NotImplementedException();
        }

        public async Task Navegar(string pagina)
        {
            try
            {
                await Shell.Current.GoToAsync(pagina, true);
            }
            catch (Exception e)
            {
                await MostrarToast(e.Message);
            }
        }

        public async Task Regresar()
        {
            try
            {
                await Shell.Current.Navigation.PopAsync();
            }
            catch (Exception e)
            {
                await MostrarToast(e.Message);
            }
        }
        #endregion
    }
}
