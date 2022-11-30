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
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            Animate();
        }

        public async Task Animate()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 4000);
            Application.Current.MainPage = new NavigationPage(new InitialMainPage());
        }
    }
}