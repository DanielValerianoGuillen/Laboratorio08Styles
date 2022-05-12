using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio08
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ExplicitDemo();
            //MainPage = new ExplicitControlDemo();
            MainPage = new NavigationPage(new MainPage());
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
