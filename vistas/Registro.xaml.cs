namespace EFARINANGOEXAMEN.vistas;

public partial class Registro : ContentPage
{
    double costo = 1500;
    string usuarioMaster;
	public Registro(string usuario)
	{
		InitializeComponent();
		lblUsuarioCon.Text = "USUARIOS CONECTADO:"+usuario;
        usuarioMaster = usuario;

    }

    private void btnCalcula_Clicked(object sender, EventArgs e)
    {
        if (txtMonto.Text == "" || txtMonto.Text == null)
        {

            DisplayAlert("Error", "El monto ingresado es incorrecto", "cerrar");
            return;
        }    
        float monto = float.Parse(txtMonto.Text);
        if (monto <= 0 || monto > 1500)
        {
            DisplayAlert("Error", "El monto inicial debe estar entre 1 y "+costo, "cerrar");
            txtCuota.Text = "0";
        }
        else {

            double comi = costo * 0.04;
            double cuoata = costo - monto + comi;
            txtCuota.Text = cuoata.ToString();
        }

    }

    private void btnDetalle_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = txtFecha.Date.ToString();
        double cuota1 = 0;
        string pais = "";
        string ciudad = "";

        if (nombre == "" || nombre==null)
        {
            DisplayAlert("error", "Ingrese un nombre", "cerrar");
            return;
        }
        if (apellido == "" || apellido == null)
        {
            DisplayAlert("error", "Ingrese un apellido", "cerrar");
            return;
        }
        if (edad == "" || edad==null)
        {
            DisplayAlert("error", "Ingrese un edad", "cerrar");
            return;
        }
        if (fecha == "" || fecha==null)
        {
            DisplayAlert("error", "Ingrese un fecha", "cerrar");
            return;
        }
        if (pck_pais.SelectedIndex < 0)
        {
            DisplayAlert("error", "Seleccione un pais", "cerrar");
            return;
        }
        else {
            pais = pck_pais.SelectedItem.ToString();
        }
        if (pck_ciudad.SelectedIndex < 0)
        {
            DisplayAlert("error", "Seleccione una ciudad", "cerrar");
            return;
        }
        else {

            ciudad = pck_ciudad.SelectedItem.ToString();
        }
        string monto = txtMonto.Text;
        if (monto == "" || monto==null)
        {
            DisplayAlert("error", "Ingrese un monto inicial", "cerrar");
            return;
            cuota1 = 0;
        }
        else {  cuota1 = double.Parse(txtCuota.Text); }

        string cuota = txtCuota.Text;
        double total = (cuota1 * 4)+double.Parse(monto);
        string[] datos = [nombre,apellido,edad,fecha,ciudad,pais,monto,cuota,total.ToString()];
        Navigation.PushAsync(new vistas.Resumen(datos, usuarioMaster));

    }
}