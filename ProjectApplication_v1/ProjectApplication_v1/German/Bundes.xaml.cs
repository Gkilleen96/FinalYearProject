﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApplication_v1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bundes : ContentPage
	{
        apiData data = new apiData();
        public Bundes (apiData d1)
		{
			InitializeComponent ();
            data = d1;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void Ger_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new GermanyHome(data));
        private async void Results_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new BundesResults(data));
        private async void Table_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new BundesTable(data));
    }
}