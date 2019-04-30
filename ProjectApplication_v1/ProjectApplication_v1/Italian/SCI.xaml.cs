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
	public partial class SCI : ContentPage
	{
        apiData data = new apiData();
        public SCI (apiData d1)
		{
			InitializeComponent ();
            data = d1;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void Ita_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new ItalyHome(data));
        private async void Stages_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new SCIResults(data));
        private async void TeamsLeft_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new SCITeams(data));
    }
}