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
	public partial class FACupStages : ContentPage
	{
        apiData data = new apiData();
        public FACupStages (apiData d1)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            data = d1;
        }
        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void Eng_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new EnglandHome(data));
        private async void FAC_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FACup(data));
    }
}