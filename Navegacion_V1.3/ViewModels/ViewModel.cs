using Navegacion_V1._3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion_V1._3.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        #region Atributos 
        private readonly INavigationService NavigationService;
        #endregion
        public ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private Command iniciaSesionCommand;
        public Command IniciaSesionCommand
        {
            get => iniciaSesionCommand ?? (new Command(async () =>
            {
                await NavigationService.Navegar(nameof(SegundaaPage));
            }));
        }
        private Command segunda;
        public Command Segunda
        {
            get => segunda ?? (new Command(async () =>
            {
                await NavigationService.Navegar(nameof(TercerPage));
            }));
        }

    }
}

