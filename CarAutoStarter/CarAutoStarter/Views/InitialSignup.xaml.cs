﻿using CarAutoStarter.Models;
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
    public partial class InitialSignup: ContentPage
    {
        public InitialSignup()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            submitBtn.IsEnabled = e.Value;
        }



        private void submitBtn_Clicked(object sender, EventArgs e)
        {

            User NewUser = new User()
            {
                FirstName = entryFirstName.Text,
                LastName = entryLastName.Text,
                Password = entryPassword.Text,
                Age = Convert.ToInt32(entryAge.Text),
                Gender = pickerGender.SelectedItem.ToString(),
                Email = entryEmail.Text,
                Phone = entryPhone.Text,
            };

            Users UserList = new Users();
            UserList.AddUser(NewUser);

            Cars CarList = new Cars();

            Settings UserSettings = new Settings();

            Journal entireJournal = new Journal();

            Application.Current.MainPage = new NavigationPage(new MainPage(NewUser, UserList, UserSettings, CarList, entireJournal));

        }
    }
}