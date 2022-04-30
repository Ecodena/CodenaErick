using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CodenaErick
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private int validacion(string usuario, string clave)
        {
            int ok = 0;
            if (usuario == "erick2022" && clave == "uisrael2022")
            {
                ok = 1;
            }
            else
            {
                ok = 0;
            }
            return ok;
        }

        private void btnInicioCesion_Clicked(object sender, EventArgs e)
        {
            
            int validar = validacion(txtusuario.Text, txtcontrasena.Text);
            if (validar == 0)
            {
                DisplayAlert("Error", "Usuario o Contraseña Incorrecta", "cerrar");

            }
            else
            {
                string usuario = "";
                usuario = txtusuario.Text;
                Navigation.PushAsync(new Registro(usuario));

            }

        }
    }
}