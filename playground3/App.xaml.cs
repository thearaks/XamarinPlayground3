using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using playground3.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace playground3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new CrashPage();
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
