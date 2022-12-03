using CarAutoStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarAutoStarter.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoPage : ContentPage
	{
        Users _UserList;
        User _CurrentUser;
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public DemoPage (User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal EntireJournal)
		{
			InitializeComponent ();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CurrentUser = CurrentUser;
            BindingContext = _CarList = CarList;
            BindingContext = _EntireJournal = EntireJournal;
        }

        async void getLoc_Clicked(object sender, EventArgs e)
        {
            var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));

            resultLocation.Text = $"lat {result.Latitude}, lng: {result.Longitude}";
        }

        private void restrictedAccount_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal, true));
        }
    }
}