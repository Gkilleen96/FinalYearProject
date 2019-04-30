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
	public partial class EuropeanHome : ContentPage
	{
        apiData data = new apiData();
        public EuropeanHome (apiData d1)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            data = d1;
        }
        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void CL_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new CL(data));
        private async void EL_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new EL(data));
        private async void SC_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new eSC(data));
        private async void CWC_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new CWC(data));
    }
}