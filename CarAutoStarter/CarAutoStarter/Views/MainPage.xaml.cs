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
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public MainPage(User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal EntireJournal, bool childAccount=false)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CurrentUser = CurrentUser;
            BindingContext = _CarList = CarList;
            BindingContext = _EntireJournal = EntireJournal;

            if (childAccount==true)
            {
                this.Title = "Child Account Similator";
                timeRemaining.IsVisible = true;
                deleteCar.IsVisible = false;
                addNewCar.IsVisible = false;
                switchUser.IsVisible = false;

            } else
            {
                this.Title = String.Format("Hello {0}", CurrentUser.FirstName);
            }

        }

        private void addNewCar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewCarDetails(_CurrentUser, _UserList, _UserSettings, _CarList));
        }

        private void settingsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage(_CurrentUser, _UserList, _UserSettings, _CarList));
        }

        private void adminPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void demoPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DemoPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void addNewUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateUserPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void car1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleCarStarterPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void car2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleCarStarterPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void car3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleCarStarterPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void car4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleCarStarterPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void car5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleCarStarterPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void switchUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwitchUserPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void deleteCar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeleteCarPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }
    }
}
