using CarAutoStarter.Models;
using CarAutoStarter.Views;
using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarAutoStarter
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new InitialSignup();
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
