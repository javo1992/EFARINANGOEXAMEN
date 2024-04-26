

namespace EFARINANGOEXAMEN.vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vistas.Acerca());
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string[] usuarios = ["estudiante2024","examen1","EFARINANGO"];
        string[] contras = ["uisrael2024","parcial1","2024"];
        int existe = 0;
        string usu = txtUsuario.Text;
        string con = txtcontra.Text;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usu == usuarios[i] && con == contras[i])
            {
                existe = 1;
                break;
            }
        }
        if (existe == 1)
        {
            Navigation.PushAsync(new vistas.Registro(usu));
        }
        else 
        {
            DisplayAlert("Error de usuario", "Usuario o contraseña invalidos", "cerrar");
        }

    }
}