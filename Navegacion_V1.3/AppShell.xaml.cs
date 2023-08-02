namespace Navegacion_V1._3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(SegundaaPage), typeof(SegundaaPage));
        Routing.RegisterRoute(nameof(TercerPage), typeof(TercerPage));

    }
}
