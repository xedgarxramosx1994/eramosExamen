using System.Runtime.CompilerServices;

namespace MauiApp1;

public partial class Resumen : ContentPage
{
	public Resumen()
	{
		InitializeComponent();
	}
	public Resumen(string name, string lastName,
		string age, string date, string country,
		string city, string amount, string total, decimal totalidad, string user)
	{
		InitializeComponent();
		lblName.Text =  lblName.Text + name;
		lblLastName.Text = lblLastName.Text + lastName;
		lblAge.Text = lblAge.Text + age;
		lblDate.Text = lblDate.Text + date;
		lblCity.Text = lblCity.Text + city;
		lblContry.Text = lblContry.Text + country;
		lblMonto.Text = lblMonto.Text + amount;
		lblMensual.Text = lblMensual.Text + total;
		lblTotal.Text = lblTotal.Text + totalidad;
		txtWelcome.Text = user;
	}
}