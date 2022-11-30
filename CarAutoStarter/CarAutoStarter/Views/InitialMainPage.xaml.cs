using CarAutoStarter.Models;
using CarAutoStarter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarAutoStarter
{
    public partial class InitialMainPage : ContentPage
    {
        public InitialMainPage()
        {
            InitializeComponent();
        }

        private void createFirstAccount_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new InitialSignup()));
        }
    }
}
