using MauiApp1;

namespace eramosExamen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new Login());
	}
}