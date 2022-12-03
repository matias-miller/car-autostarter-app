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
    public partial class CreateUserPage : ContentPage
    {
        Users _UserList;
        User _CurrentUser;
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public CreateUserPage(User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal EntireJournal)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CarList = CarList;
            BindingContext = _CurrentUser = CurrentUser;
            BindingContext = _EntireJournal = EntireJournal;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            submitBtn.IsEnabled = e.Value;
        }



        private void submitBtn_Clicked(object sender, EventArgs e)
        {

            User NewUser = new User() {
                FirstName = entryFirstName.Text,
                LastName = entryLastName.Text,
                Password = entryPassword.Text,
                Age = Convert.ToInt32(entryAge.Text),
                Gender = pickerGender.SelectedItem.ToString(),
                Email = entryEmail.Text,
                Phone = entryPhone.Text,
            };

            _UserList.AddUser(NewUser);

            Application.Current.MainPage = new NavigationPage(new MainPage(NewUser, _UserList, _UserSettings, _CarList, _EntireJournal));

        }
    }
}