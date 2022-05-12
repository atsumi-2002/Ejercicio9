using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ejercicio9
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Explicit();
            //MainPage = new ExplicitControl();
            //MainPage = new Implicit();
            //MainPage = new ImplicitControl();
            //MainPage = new Global();
            //MainPage = new Inheritance();
            MainPage = new Dynamic();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
