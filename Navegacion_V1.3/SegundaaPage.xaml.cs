using Navegacion_V1._3.ViewModels;
namespace Navegacion_V1._3;

public partial class SegundaaPage : ContentPage
{
	public SegundaaPage(ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}