using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ProjectApplication_v1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EFL2Results : ContentPage
	{
        apiData data = new apiData();
        string text = "";
		public EFL2Results (apiData d1)
		{
            InitializeComponent();
            data = d1;
            String defaultT = DateTime.Now.ToString("yyyy-MM-dd");
            dateLabel.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy");
            NavigationPage.SetHasNavigationBar(this, false);
            populateResultsData();
            checkDate(defaultT);
        }

        private async void Home_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new MainPage(data));
        private async void Ball_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new FootballHome(data));
        private async void Eng_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new EnglandHome(data));
        private async void Efl2_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new LeagueTwo(data));

        private void Calender_Clicked(object sender, EventArgs e)
        {
            datePicker.Focus();
        }


        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            clearData();
            String pickedDate = e.NewDate.ToString("ddd, dd MMMM yyyy");
            dateLabel.Text = "";
            dateLabel.Text = pickedDate;
            String date = e.NewDate.ToString("yyyy-MM-dd");
            checkDate(date);
            
        }

        public void checkDate(String date)
        {
            //Parsing json text to a C# Object
            var jsonObject = JObject.Parse(data.efl2Results);


            int x = 50335;
            //fixture 1
            for (int i = 49783; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH1.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH1.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA1.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA1.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME1.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH1.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 2
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH2.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH2.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA2.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA2.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME2.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH2.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 3
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH3.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH3.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA3.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA3.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME3.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH3.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 4
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH4.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH4.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA4.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA4.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME4.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH4.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 5
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH5.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH5.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA5.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA5.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME5.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH5.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 6
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH6.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH6.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA6.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA6.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME6.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH6.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 7
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH7.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH7.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA7.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA7.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME7.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH7.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 8
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH8.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH8.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA8.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA8.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME8.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH8.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 9
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH9.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH9.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA9.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA9.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME9.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH9.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 10
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH10.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH10.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA10.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA10.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME10.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH10.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
            //fixture 10
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH10.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH10.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA10.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA10.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME10.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH10.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }

            //fixture 11
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH11.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH11.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA11.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA11.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME11.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH11.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }

            //fixture 12
            for (int i = x; i < 50335; i++)
            {
                DateTime event_date = (DateTime)jsonObject["api"]["fixtures"][i.ToString()]["event_date"];
                String dateCheck = event_date.ToString("yyyy-MM-dd");
                if (dateCheck.Equals(date))
                {
                    TEAMH12.Text = jsonObject["api"]["fixtures"][i.ToString()]["homeTeam"].ToString();
                    SCOREH12.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsHomeTeam"].ToString();
                    TEAMA12.Text = jsonObject["api"]["fixtures"][i.ToString()]["awayTeam"].ToString();
                    SCOREA12.Text = jsonObject["api"]["fixtures"][i.ToString()]["goalsAwayTeam"].ToString();
                    TIME12.Text = jsonObject["api"]["fixtures"][i.ToString()]["statusShort"].ToString();
                    DASH12.IsVisible = true;
                    x = i + 1;
                    i = 50335;
                }
            }
        }

        public void populateResultsData()
        {
            try
            {
                

            }
            catch (AggregateException e)
            {

            }
        }
        public void clearData()
        {

            TEAMH1.Text = "";
            SCOREH1.Text = "";
            TEAMA1.Text = "";
            SCOREA1.Text = "";
            TIME1.Text = "";
            DASH1.IsVisible = false;

            TEAMH2.Text = "";
            SCOREH2.Text = "";
            TEAMA2.Text = "";
            SCOREA2.Text = "";
            TIME2.Text = "";
            DASH2.IsVisible = false;

            TEAMH3.Text = "";
            SCOREH3.Text = "";
            TEAMA3.Text = "";
            SCOREA3.Text = "";
            TIME3.Text = "";
            DASH3.IsVisible = false;

            TEAMH4.Text = "";
            SCOREH4.Text = "";
            TEAMA4.Text = "";
            SCOREA4.Text = "";
            TIME4.Text = "";
            DASH4.IsVisible = false;

            TEAMH5.Text = "";
            SCOREH5.Text = "";
            TEAMA5.Text = "";
            SCOREA5.Text = "";
            TIME5.Text = "";
            DASH5.IsVisible = false;

            TEAMH6.Text = "";
            SCOREH6.Text = "";
            TEAMA6.Text = "";
            SCOREA6.Text = "";
            TIME6.Text = "";
            DASH6.IsVisible = false;

            TEAMH7.Text = "";
            SCOREH7.Text = "";
            TEAMA7.Text = "";
            SCOREA7.Text = "";
            TIME7.Text = "";
            DASH7.IsVisible = false;

            TEAMH8.Text = "";
            SCOREH8.Text = "";
            TEAMA8.Text = "";
            SCOREA8.Text = "";
            TIME8.Text = "";
            DASH8.IsVisible = false;

            TEAMH9.Text = "";
            SCOREH9.Text = "";
            TEAMA9.Text = "";
            SCOREA9.Text = "";
            TIME9.Text = "";
            DASH9.IsVisible = false;

            TEAMH10.Text = "";
            SCOREH10.Text = "";
            TEAMA10.Text = "";
            SCOREA10.Text = "";
            TIME10.Text = "";
            DASH10.IsVisible = false;

            TEAMH11.Text = "";
            SCOREH11.Text = "";
            TEAMA11.Text = "";
            SCOREA11.Text = "";
            TIME11.Text = "";
            DASH11.IsVisible = false;

            TEAMH12.Text = "";
            SCOREH12.Text = "";
            TEAMA12.Text = "";
            SCOREA12.Text = "";
            TIME12.Text = "";
            DASH12.IsVisible = false;
        }
    }
}