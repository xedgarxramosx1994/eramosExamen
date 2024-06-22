namespace MauiApp1;

public partial class Login : ContentPage
{
	private readonly string user = "";
	private readonly string password = "";
	public Login()
	{
		InitializeComponent();
	}

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
		string[] usuario = ["estudiante", "uisrael"];
		string[] clave = ["moviles", "2024"];
		if (user == "")
		{
			if (txtPassword.Text != null && txtUser.Text != null)
				Navigation.PushAsync(new Register(txtUser.Text));
			else
				DisplayAlert("Alerta", "Ingrese sus credenciales para ingresar.", "OK");
		}
		else
		{
			if (txtUser.Text == usuario[0])
			{
				if (txtPassword.Text == clave[0])
				{
					Navigation.PushAsync(new Register(txtUser.Text));
				}
				else
					DisplayAlert("Error", "Verifique sus credenciales.", "OK");
			}
			else if (txtUser.Text == usuario[1])
			{
				if (txtPassword.Text == clave[1])
					Navigation.PushAsync(new Register(txtUser.Text));
				else
					DisplayAlert("Error", "Verifique sus credenciales.", "OK");
			}
			else
				DisplayAlert("Error", "Verifique sus credenciales.", "OK");
		}
	}
}