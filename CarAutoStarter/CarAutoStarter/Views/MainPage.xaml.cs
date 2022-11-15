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
        Users _UserList;
        User _CurrentUser;
        public MainPage(User CurrentUser, Users UserList)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _CurrentUser = CurrentUser;
            this.Title = String.Format("Hello {0}", CurrentUser.FirstName);
        }

        private void addNewCar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewCarDetails());
        }

        private void settingsPage_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SettingsPage());
        }

        private void addUserPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateUserPage(_CurrentUser, _UserList));
        }
    }
}
