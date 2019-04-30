using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Text;

namespace ProjectApplication_v1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EFL2Table : ContentPage
	{
        apiData data = new apiData();
        public EFL2Table (apiData d1)
		{
			InitializeComponent ();
            data = d1;
            NavigationPage.SetHasNavigationBar(this, false);
            populateLeagueData();
        }
        public void populateLeagueData()
        {
           

            try
            {
               


                //Parsing json text to a C# Object
                var jsonObject = JObject.Parse(data.efl2Table);


                //Populating table data

                Team1.Text = jsonObject["api"]["standings"][0][0]["teamName"].ToString();
                MP1.Text = jsonObject["api"]["standings"][0][0]["matchsPlayed"].ToString();
                W1.Text = jsonObject["api"]["standings"][0][0]["win"].ToString();
                D1.Text = jsonObject["api"]["standings"][0][0]["draw"].ToString();
                L1.Text = jsonObject["api"]["standings"][0][0]["lose"].ToString();
                GF1.Text = jsonObject["api"]["standings"][0][0]["goalsFor"].ToString();
                GA1.Text = jsonObject["api"]["standings"][0][0]["goalsAgainst"].ToString();
                GD1.Text = jsonObject["api"]["standings"][0][0]["goalsDiff"].ToString();
                PTS1.Text = jsonObject["api"]["standings"][0][0]["points"].ToString();

                Team2.Text = jsonObject["api"]["standings"][0][1]["teamName"].ToString();
                MP2.Text = jsonObject["api"]["standings"][0][1]["matchsPlayed"].ToString();
                W2.Text = jsonObject["api"]["standings"][0][1]["win"].ToString();
                D2.Text = jsonObject["api"]["standings"][0][1]["draw"].ToString();
                L2.Text = jsonObject["api"]["standings"][0][1]["lose"].ToString();
                GF2.Text = jsonObject["api"]["standings"][0][1]["goalsFor"].ToString();
                GA2.Text = jsonObject["api"]["standings"][0][1]["goalsAgainst"].ToString();
                GD2.Text = jsonObject["api"]["standings"][0][1]["goalsDiff"].ToString();
                PTS2.Text = jsonObject["api"]["standings"][0][1]["points"].ToString();

                Team3.Text = jsonObject["api"]["standings"][0][2]["teamName"].ToString();
                MP3.Text = jsonObject["api"]["standings"][0][2]["matchsPlayed"].ToString();
                W3.Text = jsonObject["api"]["standings"][0][2]["win"].ToString();
                D3.Text = jsonObject["api"]["standings"][0][2]["draw"].ToString();
                L3.Text = jsonObject["api"]["standings"][0][2]["lose"].ToString();
                GF3.Text = jsonObject["api"]["standings"][0][2]["goalsFor"].ToString();
                GA3.Text = jsonObject["api"]["standings"][0][2]["goalsAgainst"].ToString();
                GD3.Text = jsonObject["api"]["standings"][0][2]["goalsDiff"].ToString();
                PTS3.Text = jsonObject["api"]["standings"][0][2]["points"].ToString();

                Team4.Text = jsonObject["api"]["standings"][0][3]["teamName"].ToString();
                MP4.Text = jsonObject["api"]["standings"][0][3]["matchsPlayed"].ToString();
                W4.Text = jsonObject["api"]["standings"][0][3]["win"].ToString();
                D4.Text = jsonObject["api"]["standings"][0][3]["draw"].ToString();
                L4.Text = jsonObject["api"]["standings"][0][3]["lose"].ToString();
                GF4.Text = jsonObject["api"]["standings"][0][3]["goalsFor"].ToString();
                GA4.Text = jsonObject["api"]["standings"][0][3]["goalsAgainst"].ToString();
                GD4.Text = jsonObject["api"]["standings"][0][3]["goalsDiff"].ToString();
                PTS4.Text = jsonObject["api"]["standings"][0][3]["points"].ToString();

                Team5.Text = jsonObject["api"]["standings"][0][4]["teamName"].ToString();
                MP5.Text = jsonObject["api"]["standings"][0][4]["matchsPlayed"].ToString();
                W5.Text = jsonObject["api"]["standings"][0][4]["win"].ToString();
                D5.Text = jsonObject["api"]["standings"][0][4]["draw"].ToString();
                L5.Text = jsonObject["api"]["standings"][0][4]["lose"].ToString();
                GF5.Text = jsonObject["api"]["standings"][0][4]["goalsFor"].ToString();
                GA5.Text = jsonObject["api"]["standings"][0][4]["goalsAgainst"].ToString();
                GD5.Text = jsonObject["api"]["standings"][0][4]["goalsDiff"].ToString();
                PTS5.Text = jsonObject["api"]["standings"][0][4]["points"].ToString();

                Team6.Text = jsonObject["api"]["standings"][0][5]["teamName"].ToString();
                MP6.Text = jsonObject["api"]["standings"][0][5]["matchsPlayed"].ToString();
                W6.Text = jsonObject["api"]["standings"][0][5]["win"].ToString();
                D6.Text = jsonObject["api"]["standings"][0][5]["draw"].ToString();
                L6.Text = jsonObject["api"]["standings"][0][5]["lose"].ToString();
                GF6.Text = jsonObject["api"]["standings"][0][5]["goalsFor"].ToString();
                GA6.Text = jsonObject["api"]["standings"][0][5]["goalsAgainst"].ToString();
                GD6.Text = jsonObject["api"]["standings"][0][5]["goalsDiff"].ToString();
                PTS6.Text = jsonObject["api"]["standings"][0][5]["points"].ToString();

                Team7.Text = jsonObject["api"]["standings"][0][6]["teamName"].ToString();
                MP7.Text = jsonObject["api"]["standings"][0][6]["matchsPlayed"].ToString();
                W7.Text = jsonObject["api"]["standings"][0][6]["win"].ToString();
                D7.Text = jsonObject["api"]["standings"][0][6]["draw"].ToString();
                L7.Text = jsonObject["api"]["standings"][0][6]["lose"].ToString();
                GF7.Text = jsonObject["api"]["standings"][0][6]["goalsFor"].ToString();
                GA7.Text = jsonObject["api"]["standings"][0][6]["goalsAgainst"].ToString();
                GD7.Text = jsonObject["api"]["standings"][0][6]["goalsDiff"].ToString();
                PTS7.Text = jsonObject["api"]["standings"][0][6]["points"].ToString();

                Team8.Text = jsonObject["api"]["standings"][0][7]["teamName"].ToString();
                MP8.Text = jsonObject["api"]["standings"][0][7]["matchsPlayed"].ToString();
                W8.Text = jsonObject["api"]["standings"][0][7]["win"].ToString();
                D8.Text = jsonObject["api"]["standings"][0][7]["draw"].ToString();
                L8.Text = jsonObject["api"]["standings"][0][7]["lose"].ToString();
                GF8.Text = jsonObject["api"]["standings"][0][7]["goalsFor"].ToString();
                GA8.Text = jsonObject["api"]["standings"][0][7]["goalsAgainst"].ToString();
                GD8.Text = jsonObject["api"]["standings"][0][7]["goalsDiff"].ToString();
                PTS8.Text = jsonObject["api"]["standings"][0][7]["points"].ToString();

                Team9.Text = jsonObject["api"]["standings"][0][8]["teamName"].ToString();
                MP9.Text = jsonObject["api"]["standings"][0][8]["matchsPlayed"].ToString();
                W9.Text = jsonObject["api"]["standings"][0][8]["win"].ToString();
                D9.Text = jsonObject["api"]["standings"][0][8]["draw"].ToString();
                L9.Text = jsonObject["api"]["standings"][0][8]["lose"].ToString();
                GF9.Text = jsonObject["api"]["standings"][0][8]["goalsFor"].ToString();
                GA9.Text = jsonObject["api"]["standings"][0][8]["goalsAgainst"].ToString();
                GD9.Text = jsonObject["api"]["standings"][0][8]["goalsDiff"].ToString();
                PTS9.Text = jsonObject["api"]["standings"][0][8]["points"].ToString();

                Team10.Text = jsonObject["api"]["standings"][0][9]["teamName"].ToString();
                MP10.Text = jsonObject["api"]["standings"][0][9]["matchsPlayed"].ToString();
                W10.Text = jsonObject["api"]["standings"][0][9]["win"].ToString();
                D10.Text = jsonObject["api"]["standings"][0][9]["draw"].ToString();
                L10.Text = jsonObject["api"]["standings"][0][9]["lose"].ToString();
                GF10.Text = jsonObject["api"]["standings"][0][9]["goalsFor"].ToString();
                GA10.Text = jsonObject["api"]["standings"][0][9]["goalsAgainst"].ToString();
                GD10.Text = jsonObject["api"]["standings"][0][9]["goalsDiff"].ToString();
                PTS10.Text = jsonObject["api"]["standings"][0][9]["points"].ToString();

                Team11.Text = jsonObject["api"]["standings"][0][10]["teamName"].ToString();
                MP11.Text = jsonObject["api"]["standings"][0][10]["matchsPlayed"].ToString();
                W11.Text = jsonObject["api"]["standings"][0][10]["win"].ToString();
                D11.Text = jsonObject["api"]["standings"][0][10]["draw"].ToString();
                L11.Text = jsonObject["api"]["standings"][0][10]["lose"].ToString();
                GF11.Text = jsonObject["api"]["standings"][0][10]["goalsFor"].ToString();
                GA11.Text = jsonObject["api"]["standings"][0][10]["goalsAgainst"].ToString();
                GD11.Text = jsonObject["api"]["standings"][0][10]["goalsDiff"].ToString();
                PTS11.Text = jsonObject["api"]["standings"][0][10]["points"].ToString();

                Team12.Text = jsonObject["api"]["standings"][0][11]["teamName"].ToString();
                MP12.Text = jsonObject["api"]["standings"][0][11]["matchsPlayed"].ToString();
                W12.Text = jsonObject["api"]["standings"][0][11]["win"].ToString();
                D12.Text = jsonObject["api"]["standings"][0][11]["draw"].ToString();
                L12.Text = jsonObject["api"]["standings"][0][11]["lose"].ToString();
                GF12.Text = jsonObject["api"]["standings"][0][11]["goalsFor"].ToString();
                GA12.Text = jsonObject["api"]["standings"][0][11]["goalsAgainst"].ToString();
                GD12.Text = jsonObject["api"]["standings"][0][11]["goalsDiff"].ToString();
                PTS12.Text = jsonObject["api"]["standings"][0][11]["points"].ToString();

                Team13.Text = jsonObject["api"]["standings"][0][12]["teamName"].ToString();
                MP13.Text = jsonObject["api"]["standings"][0][12]["matchsPlayed"].ToString();
                W13.Text = jsonObject["api"]["standings"][0][12]["win"].ToString();
                D13.Text = jsonObject["api"]["standings"][0][12]["draw"].ToString();
                L13.Text = jsonObject["api"]["standings"][0][12]["lose"].ToString();
                GF13.Text = jsonObject["api"]["standings"][0][12]["goalsFor"].ToString();
                GA13.Text = jsonObject["api"]["standings"][0][12]["goalsAgainst"].ToString();
                GD13.Text = jsonObject["api"]["standings"][0][12]["goalsDiff"].ToString();
                PTS13.Text = jsonObject["api"]["standings"][0][12]["points"].ToString();

                Team14.Text = jsonObject["api"]["standings"][0][13]["teamName"].ToString();
                MP14.Text = jsonObject["api"]["standings"][0][13]["matchsPlayed"].ToString();
                W14.Text = jsonObject["api"]["standings"][0][13]["win"].ToString();
                D14.Text = jsonObject["api"]["standings"][0][13]["draw"].ToString();
                L14.Text = jsonObject["api"]["standings"][0][13]["lose"].ToString();
                GF14.Text = jsonObject["api"]["standings"][0][13]["goalsFor"].ToString();
                GA14.Text = jsonObject["api"]["standings"][0][13]["goalsAgainst"].ToString();
                GD14.Text = jsonObject["api"]["standings"][0][13]["goalsDiff"].ToString();
                PTS14.Text = jsonObject["api"]["standings"][0][13]["points"].ToString();

                Team15.Text = jsonObject["api"]["standings"][0][14]["teamName"].ToString();
                MP15.Text = jsonObject["api"]["standings"][0][14]["matchsPlayed"].ToString();
                W15.Text = jsonObject["api"]["standings"][0][14]["win"].ToString();
                D15.Text = jsonObject["api"]["standings"][0][14]["draw"].ToString();
                L15.Text = jsonObject["api"]["standings"][0][14]["lose"].ToString();
                GF15.Text = jsonObject["api"]["standings"][0][14]["goalsFor"].ToString();
                GA15.Text = jsonObject["api"]["standings"][0][14]["goalsAgainst"].ToString();
                GD15.Text = jsonObject["api"]["standings"][0][14]["goalsDiff"].ToString();
                PTS15.Text = jsonObject["api"]["standings"][0][14]["points"].ToString();

                Team16.Text = jsonObject["api"]["standings"][0][15]["teamName"].ToString();
                MP16.Text = jsonObject["api"]["standings"][0][15]["matchsPlayed"].ToString();
                W16.Text = jsonObject["api"]["standings"][0][15]["win"].ToString();
                D16.Text = jsonObject["api"]["standings"][0][15]["draw"].ToString();
                L16.Text = jsonObject["api"]["standings"][0][15]["lose"].ToString();
                GF16.Text = jsonObject["api"]["standings"][0][15]["goalsFor"].ToString();
                GA16.Text = jsonObject["api"]["standings"][0][15]["goalsAgainst"].ToString();
                GD16.Text = jsonObject["api"]["standings"][0][15]["goalsDiff"].ToString();
                PTS16.Text = jsonObject["api"]["standings"][0][15]["points"].ToString();

                Team17.Text = jsonObject["api"]["standings"][0][16]["teamName"].ToString();
                MP17.Text = jsonObject["api"]["standings"][0][16]["matchsPlayed"].ToString();
                W17.Text = jsonObject["api"]["standings"][0][16]["win"].ToString();
                D17.Text = jsonObject["api"]["standings"][0][16]["draw"].ToString();
                L17.Text = jsonObject["api"]["standings"][0][16]["lose"].ToString();
                GF17.Text = jsonObject["api"]["standings"][0][16]["goalsFor"].ToString();
                GA17.Text = jsonObject["api"]["standings"][0][16]["goalsAgainst"].ToString();
                GD17.Text = jsonObject["api"]["standings"][0][16]["goalsDiff"].ToString();
                PTS17.Text = jsonObject["api"]["standings"][0][16]["points"].ToString();

                Team18.Text = jsonObject["api"]["standings"][0][17]["teamName"].ToString();
                MP18.Text = jsonObject["api"]["standings"][0][17]["matchsPlayed"].ToString();
                W18.Text = jsonObject["api"]["standings"][0][17]["win"].ToString();
                D18.Text = jsonObject["api"]["standings"][0][17]["draw"].ToString();
                L18.Text = jsonObject["api"]["standings"][0][17]["lose"].ToString();
                GF18.Text = jsonObject["api"]["standings"][0][17]["goalsFor"].ToString();
                GA18.Text = jsonObject["api"]["standings"][0][17]["goalsAgainst"].ToString();
                GD18.Text = jsonObject["api"]["standings"][0][17]["goalsDiff"].ToString();
                PTS18.Text = jsonObject["api"]["standings"][0][17]["points"].ToString();

                Team19.Text = jsonObject["api"]["standings"][0][18]["teamName"].ToString();
                MP19.Text = jsonObject["api"]["standings"][0][18]["matchsPlayed"].ToString();
                W19.Text = jsonObject["api"]["standings"][0][18]["win"].ToString();
                D19.Text = jsonObject["api"]["standings"][0][18]["draw"].ToString();
                L19.Text = jsonObject["api"]["standings"][0][18]["lose"].ToString();
                GF19.Text = jsonObject["api"]["standings"][0][18]["goalsFor"].ToString();
                GA19.Text = jsonObject["api"]["standings"][0][18]["goalsAgainst"].ToString();
                GD19.Text = jsonObject["api"]["standings"][0][18]["goalsDiff"].ToString();
                PTS19.Text = jsonObject["api"]["standings"][0][18]["points"].ToString();

                Team20.Text = jsonObject["api"]["standings"][0][19]["teamName"].ToString();
                MP20.Text = jsonObject["api"]["standings"][0][19]["matchsPlayed"].ToString();
                W20.Text = jsonObject["api"]["standings"][0][19]["win"].ToString();
                D20.Text = jsonObject["api"]["standings"][0][19]["draw"].ToString();
                L20.Text = jsonObject["api"]["standings"][0][19]["lose"].ToString();
                GF20.Text = jsonObject["api"]["standings"][0][19]["goalsFor"].ToString();
                GA20.Text = jsonObject["api"]["standings"][0][19]["goalsAgainst"].ToString();
                GD20.Text = jsonObject["api"]["standings"][0][19]["goalsDiff"].ToString();
                PTS20.Text = jsonObject["api"]["standings"][0][19]["points"].ToString();

                Team21.Text = jsonObject["api"]["standings"][0][20]["teamName"].ToString();
                MP21.Text = jsonObject["api"]["standings"][0][20]["matchsPlayed"].ToString();
                W21.Text = jsonObject["api"]["standings"][0][20]["win"].ToString();
                D21.Text = jsonObject["api"]["standings"][0][20]["draw"].ToString();
                L21.Text = jsonObject["api"]["standings"][0][20]["lose"].ToString();
                GF21.Text = jsonObject["api"]["standings"][0][20]["goalsFor"].ToString();
                GA21.Text = jsonObject["api"]["standings"][0][20]["goalsAgainst"].ToString();
                GD21.Text = jsonObject["api"]["standings"][0][20]["goalsDiff"].ToString();
                PTS21.Text = jsonObject["api"]["standings"][0][20]["points"].ToString();

                Team22.Text = jsonObject["api"]["standings"][0][21]["teamName"].ToString();
                MP22.Text = jsonObject["api"]["standings"][0][21]["matchsPlayed"].ToString();
                W22.Text = jsonObject["api"]["standings"][0][21]["win"].ToString();
                D22.Text = jsonObject["api"]["standings"][0][21]["draw"].ToString();
                L22.Text = jsonObject["api"]["standings"][0][21]["lose"].ToString();
                GF22.Text = jsonObject["api"]["standings"][0][21]["goalsFor"].ToString();
                GA22.Text = jsonObject["api"]["standings"][0][21]["goalsAgainst"].ToString();
                GD22.Text = jsonObject["api"]["standings"][0][21]["goalsDiff"].ToString();
                PTS22.Text = jsonObject["api"]["standings"][0][21]["points"].ToString();

                Team23.Text = jsonObject["api"]["standings"][0][22]["teamName"].ToString();
                MP23.Text = jsonObject["api"]["standings"][0][22]["matchsPlayed"].ToString();
                W23.Text = jsonObject["api"]["standings"][0][22]["win"].ToString();
                D23.Text = jsonObject["api"]["standings"][0][22]["draw"].ToString();
                L23.Text = jsonObject["api"]["standings"][0][22]["lose"].ToString();
                GF23.Text = jsonObject["api"]["standings"][0][22]["goalsFor"].ToString();
                GA23.Text = jsonObject["api"]["standings"][0][22]["goalsAgainst"].ToString();
                GD23.Text = jsonObject["api"]["standings"][0][22]["goalsDiff"].ToString();
                PTS23.Text = jsonObject["api"]["standings"][0][22]["points"].ToString();

                Team24.Text = jsonObject["api"]["standings"][0][23]["teamName"].ToString();
                MP24.Text = jsonObject["api"]["standings"][0][23]["matchsPlayed"].ToString();
                W24.Text = jsonObject["api"]["standings"][0][23]["win"].ToString();
                D24.Text = jsonObject["api"]["standings"][0][23]["draw"].ToString();
                L24.Text = jsonObject["api"]["standings"][0][23]["lose"].ToString();
                GF24.Text = jsonObject["api"]["standings"][0][23]["goalsFor"].ToString();
                GA24.Text = jsonObject["api"]["standings"][0][23]["goalsAgainst"].ToString();
                GD24.Text = jsonObject["api"]["standings"][0][23]["goalsDiff"].ToString();
                PTS24.Text = jsonObject["api"]["standings"][0][23]["points"].ToString();
            }
            catch (AggregateException e)
            {

            }
        }
        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void Eng_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new EnglandHome(data));
        private async void Efl2_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new LeagueTwo(data));
    }
}