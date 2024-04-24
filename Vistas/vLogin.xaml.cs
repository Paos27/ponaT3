namespace ponaT3.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {



        /* string usuario = "Carlos";
         string contrasena = "carlos123";*/

        string nombreUsuarioIngresado = txtUsuario.Text;
        string contraseñaIngresada = txtContrasena.Text;


        List<Usuario> usuariosPermitidos = new List<Usuario>()
        {
            new Usuario { NombreUsuario = "Carlos", Contrasena = "carlos123" },
            new Usuario { NombreUsuario = "Ana", Contrasena = "ana123" },
            new Usuario { NombreUsuario = "Jose", Contrasena = "jose123" }
        };

             


       bool inicioSesionValido = usuariosPermitidos.Any(usuario =>
        usuario.NombreUsuario == nombreUsuarioIngresado && usuario.Contrasena == contraseñaIngresada);



        if (inicioSesionValido)
        {

            Navigation.PushAsync(new vInicio());

        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contrasena incorrectos", "Cerrar");
        }



    }
}