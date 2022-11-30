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
        public CreateUserPage(User CurrentUser, Users UserList)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _CurrentUser = CurrentUser;
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
            Application.Current.MainPage = new NavigationPage(new MainPage(NewUser, _UserList));

        }
    }
}