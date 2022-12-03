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
    public partial class SwitchUserPage : ContentPage
    {
        Users _UserList;
        User _CurrentUser;
        Settings _UserSettings;
        Cars _CarList;
        Journal _EntireJournal;
        public SwitchUserPage(User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal EntireJournal)
        {
            InitializeComponent();
            BindingContext = _UserList = UserList;
            BindingContext = _UserSettings = UserSettings;
            BindingContext = _CurrentUser = CurrentUser;
            BindingContext = _CarList = CarList;
            BindingContext = _EntireJournal = EntireJournal;
        }
    }
}