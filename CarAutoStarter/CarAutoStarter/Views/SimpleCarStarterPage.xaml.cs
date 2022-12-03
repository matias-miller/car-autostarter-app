using CarAutoStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarAutoStarter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCarStarterPage : ContentPage
    {
        Users _UserList;
        User _CurrentUser;
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public SimpleCarStarterPage(User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal entireJournal)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CurrentUser = CurrentUser;
            BindingContext = _CarList = CarList;
            BindingContext = _EntireJournal = entireJournal;
        }

        private void gotoAdvancedStarter_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdvancedCarStarterPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void gotoJournal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VehicleJournal(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));
        }

        private void carEngine_Clicked(object sender, EventArgs e)
        {
            if (carEngine.Text == "Engine OFF. Click to START.") {
                carEngine.Text = "Engine ON. Click to STOP.";
                carEngine.BackgroundColor = Color.Green;
            } else {
                carEngine.Text = "Engine OFF. Click to START.";
                carEngine.BackgroundColor = Color.Red;
            }
        }

        private void carAlarm_Clicked(object sender, EventArgs e)
        {
            if(carAlarm.Text == "Car Alarm OFF. Click to Turn ON") {
                carAlarm.Text = "Car Alarm ON. Click to Turn OFF";
                carAlarm.BackgroundColor = Color.Green;
            } else {
                carAlarm.Text = "Car Alarm OFF. Click to Turn ON";
                carAlarm.BackgroundColor = Color.Red;
            }
        }

        private void acUnit_Clicked(object sender, EventArgs e)
        {
            if (acUnit.Text == "A/C OFF. Click to Turn ON.") {
                acUnit.Text = "A/C ON. Click to Turn OFF.";
                acUnit.BackgroundColor = Color.Red;
            }
            else {
                acUnit.Text = "A/C OFF. Click to Turn ON.";
                acUnit.BackgroundColor = Color.Green;
            }
        }
    }
}