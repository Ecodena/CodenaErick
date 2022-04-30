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
    public partial class Registro : ContentPage
    {
   
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double montoInicial = 0;
            double cuotaMensual = 0;

            montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            if (montoInicial > 1 && montoInicial < 3000)

            {
                cuotaMensual = ((3000 - montoInicial) / 5) + (((3000 - montoInicial) / 5) * 5) / 100;
                lblPagoMensual.Text=cuotaMensual.ToString();


               
            }
            else
            {


                DisplayAlert("ERROR", "EL MONTO INICIAL DEBE SER MAYOR A 1 Y MENOS DE 3000", "CERRAR");

            }

        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string total = lblPagoMensual.Text;
           Navigation.PushAsync(new Resumen(nombre, total));
        }
    }
}