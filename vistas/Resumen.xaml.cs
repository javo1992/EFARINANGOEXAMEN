namespace EFARINANGOEXAMEN.vistas;

public partial class Resumen : ContentPage
{
	public Resumen(string[] datos,string usuario)
	{
		InitializeComponent();
        lblUsuarioCon.Text = "usuario conectado:"+usuario;
        txtNombre.Text = datos[0];
        txtApellido.Text = datos[1];
        txtEdad.Text = datos[2];
        txtFecha.Text = datos[3];
        txtCiudad.Text = datos[4];
        txtPais.Text = datos[5];
        txtMonto.Text = datos[6];
        txtCuota.Text = datos[7];
        txtTotal.Text = datos[8];
    }

    private void btnCerrarSession_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vistas.Login());

    }
}