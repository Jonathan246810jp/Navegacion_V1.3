using Navegacion_V1._3.ViewModels;
namespace Navegacion_V1._3;

public partial class MainPage : ContentPage
{
	public MainPage(ViewModel  vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

