using Navegacion_V1._3.Services;
using Navegacion_V1._3.ViewModels;
using Navegacion_V1._3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion_V1._3.Helpers
{
    public static class ContenedorDependencia
    {

        #region Metodos
        public static IServiceCollection AgregarDependencias(this IServiceCollection services)
        {
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<ViewModel>();
            services.AddTransient<SegundaaPage>();
            services.AddTransient<MainPage>();
            return services;
        }
        #endregion
    }
}
