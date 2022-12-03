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
	public partial class DeleteCarPage : ContentPage
	{
		public DeleteCarPage (User CurrentUser, Users UserList, Settings UserSettings, Cars CarList, Journal EntireJournal)
		{
			InitializeComponent ();
		}
	}
}