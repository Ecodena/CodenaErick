using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CodenaErick
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new inicio1();
            MainPage = new NavigationPage(new inicio1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
