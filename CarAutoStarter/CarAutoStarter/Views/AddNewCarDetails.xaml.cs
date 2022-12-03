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
    public partial class AddNewCarDetails : ContentPage
    {
        Users _UserList;
        User _CurrentUser;
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public AddNewCarDetails(User CurrentUser, Users UserList, Settings UserSettings, Cars CarList)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CarList = CarList;
            BindingContext = _CurrentUser = CurrentUser;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            submitBtn.IsEnabled = e.Value;
        }



        private void submitBtn_Clicked(object sender, EventArgs e)
        {

            Car newCar = new Car()
            {
                carModel = entryCarNickname.Text,
                carNickName = entryCarNickname.Text,
                carModelYear = Convert.ToInt32(entryCarModelYear.Text)
            };

            _CarList.AddCar(newCar);

            Application.Current.MainPage = new NavigationPage(new MainPage(_CurrentUser, _UserList, _UserSettings, _CarList, _EntireJournal));

        }
    }
}