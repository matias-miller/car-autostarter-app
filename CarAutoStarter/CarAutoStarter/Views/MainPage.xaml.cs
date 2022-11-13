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
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            this.Title = "Welcome";
            
        }

        private void AddNewCar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewCarDetails());
        }

        private void CarTest_Clicked(object sender, EventArgs e)
        {

        }

        private void NewUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateUserPage());
        }
    }
}
