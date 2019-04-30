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
	public partial class FranceHome : ContentPage
	{
        apiData data = new apiData();
        public FranceHome (apiData d1)
		{
			InitializeComponent ();
            data = d1;
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void FL_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FL(data));
        private async void CDF_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new CDF(data));
        private async void CDLL_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new CDLL(data));
    }
}