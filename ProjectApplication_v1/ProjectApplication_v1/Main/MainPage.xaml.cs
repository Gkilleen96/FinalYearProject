using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectApplication_v1
{
    public partial class MainPage : ContentPage
    {
        apiData data = new apiData();
        public MainPage(apiData d1)
        {
            InitializeComponent();
            data = d1;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void Help_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new HelpPage(data));
    }
}
