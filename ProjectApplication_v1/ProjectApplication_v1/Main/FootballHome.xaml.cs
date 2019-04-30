using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApplication_v1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FootballHome : ContentPage
	{
        apiData data = new apiData();
		public FootballHome (apiData d1)
		{
			InitializeComponent ();
            data = d1;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Eng_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new EnglandHome(data));
        private async void Esp_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new SpainHome(data));
        private async void Ita_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new ItalyHome(data));
        private async void Ger_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new GermanyHome(data));
        private async void Fra_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FranceHome(data));
        private async void Eu_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new EuropeanHome(data));
    }
}