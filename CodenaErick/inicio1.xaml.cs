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
    public partial class inicio1 : ContentPage
    {
        public inicio1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
            DisplayAlert("MENSAJE", "BIENVENIDO AL SISTEMA", "CERRAR");


        }
    }
}