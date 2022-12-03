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
    public partial class AdvancedCarStarterPage : ContentPage
    {
        Users _UserList;
        User _CurrentUser;
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public AdvancedCarStarterPage(User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal entireJournal)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CurrentUser = CurrentUser;
            BindingContext = _CarList = CarList;
            BindingContext = _EntireJournal = entireJournal;
        }

        private void windowStatus_Clicked(object sender, EventArgs e)
        {
            if (windowStatus.Text == "Windows rolled DOWN. Click to roll UP.")
            {
                windowStatus.Text = "Windows rolled UP. Click to roll DOWN.";
                windowStatus.BackgroundColor = Color.Green;
            }
            else
            {
                windowStatus.Text = "Windows rolled DOWN. Click to roll UP.";
                windowStatus.BackgroundColor = Color.Red;
            }

        }

        private void heatedSeats_Clicked(object sender, EventArgs e)
        {
            if(heatedSeats.Text == "Heating seats OFF. Click to Turn ON.")
            {
                heatedSeats.Text = "Heating seats ON. Click to Turn OFF.";
                heatedSeats.BackgroundColor = Color.Green;
            }
            else
            {
                heatedSeats.Text = "Heating seats OFF. Click to Turn ON.";
                heatedSeats.BackgroundColor = Color.Red;
            }
        }

        private void acUnit_Clicked(object sender, EventArgs e)
        {
            if(acUnit.Text == "A/C OFF. Click to Turn ON.")
            {
                acUnit.Text = "A/C ON. Click to Turn OFF.";
                acUnit.BackgroundColor = Color.Green;
            }
            else
            {
                acUnit.Text = "A/C OFF. Click to Turn ON.";
                acUnit.BackgroundColor = Color.Red;
            }
        }

        private void carAlarm_Clicked(object sender, EventArgs e)
        {
            if (carAlarm.Text == "Car Alarm OFF. Click to Turn ON")
            {
                carAlarm.Text = "Car Alarm ON. Click to Turn OFF";
                carAlarm.BackgroundColor = Color.Green;
            }
            else
            {
                carAlarm.Text = "Car Alarm OFF. Click to Turn ON";
                carAlarm.BackgroundColor = Color.Red;
            }
        }

        private void nightMode_Clicked(object sender, EventArgs e)
        {
            if (nightMode.Text == "Nightmode DISABLED. Click to ENABLE.")
            {
                nightMode.Text = "Nightmode ENABLED. Click to DISABLED.";
                nightMode.BackgroundColor = Color.Green;
            }
            else
            {
                nightMode.Text = "Nightmode DISABLED. Click to ENABLE.";
                nightMode.BackgroundColor = Color.Red;
            }
        }

        private void dogMode_Clicked(object sender, EventArgs e)
        {
            if (dogMode.Text == "Passanger/Dog mode DISABLED. Click to ENABLE.")
            {
                dogMode.Text = "Passanger/Dog mode ENABLED. Click to DISABLE.";
                dogMode.BackgroundColor = Color.Green;
            }
            else
            {
                dogMode.Text = "Passanger/Dog mode DISABLED. Click to ENABLE.";
                dogMode.BackgroundColor = Color.Red;
            }
        }

        private void carEngine_Clicked(object sender, EventArgs e)
        {
            if (carEngine.Text == "Engine OFF. Click to START.")
            {
                carEngine.Text = "Engine ON. Click to STOP.";
                carEngine.BackgroundColor = Color.Green;
            }
            else
            {
                carEngine.Text = "Engine OFF. Click to START.";
                carEngine.BackgroundColor = Color.Red;
            }
        }
    }
}