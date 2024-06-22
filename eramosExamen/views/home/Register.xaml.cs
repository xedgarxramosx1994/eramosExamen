using Microsoft.Extensions.Options;

namespace MauiApp1;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
	public Register(string user)
	{
		InitializeComponent();
		txtWelcome.Text = txtWelcome.Text + user;
	}

	private void btnCalcular_Clicked(object sender, EventArgs e)
	{
		decimal totalidad = 1500;
		if (pkCiudad.SelectedIndex != -1 && pkPais.SelectedIndex != -1 && txtMonto.Text != null)
		{
			if (txtMonto.Text == "1500")
				DisplayAlert("Alerta", "No puede cancelar la totalidad del curso", "ok");
			else
			{
				decimal montoFaltante = Convert.ToDecimal(txtMonto.Text) - totalidad;
				decimal pagoMensual = montoFaltante / 4;
				decimal porcentaje = totalidad * Convert.ToDecimal(0.4);
				txtTotal.Text = Convert.ToString(pagoMensual + porcentaje);
			}
		}
		else
			DisplayAlert("Alerta", "Complete todos los campos", "ok");
	}
	private void btnResume_Clicked(object sender, EventArgs e)
	{
		if (txtName.Text != null && txtLastName.Text != null && txtAge.Text != null)
			Navigation.PushAsync(new Resumen(txtName.Text, txtLastName.Text, txtAge.Text, datePicker.Date.ToShortDateString(), pkPais.SelectedItem.ToString(), pkCiudad.SelectedItem.ToString(), txtMonto.Text, txtTotal.Text, (Convert.ToDecimal(txtMonto.Text) + (Convert.ToDecimal(txtTotal.Text) * 4)), txtWelcome.Text));
	}
}