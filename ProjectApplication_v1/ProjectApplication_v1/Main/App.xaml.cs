using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Text;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjectApplication_v1
{
    public partial class App : Application
    {
        apiData data = new apiData();
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage(data));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            /*data.eplResults = initEPLResults();
            data.eplTable = initEPLTable();
            data.chaResults = initCHAResults();
            data.chaTable = initCHATable();
            data.efl1Results = initEFL1Results();
            data.efl1Table = initEFL1Table();
            data.efl2Results = initEFL2Results();
            data.efl2Table = initEFL2Table();
            data.espResults = initESPResults();
            data.espTable = initESPTable();
            data.fraResults = initFRAResults();
            data.fraTable = initFRATable();
            data.itaResults = initITAResults();
            data.itaTable = initITATable();
            data.gerResults = initGERResults();
            data.gerTable = initGERTable();*/
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public string initEPLResults()
        {
            string EPLResults="";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/2");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                EPLResults = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return EPLResults;
        }
        public string initEPLTable()
        {
            string EPLTable = "";

            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/2");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                string text = readStream.ReadToEnd();
                EPLTable = text;
                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();


            }
            catch (AggregateException e)
            {

            }
            return EPLTable;
        }
        public string initCHAResults()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/3");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initCHATable()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/3");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initEFL1Results()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/164");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initEFL1Table()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/164");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initEFL2Results()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/167");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initEFL2Table()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/167");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();


                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initGERResults()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/8");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initGERTable()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/8");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initITAResults()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/94");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initITATable()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/94");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initESPResults()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/87");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initESPTable()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/87");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initFRAResults()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/fixtures/league/4");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
        public string initFRATable()
        {
            string result = "";
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("https://api-football-v1.p.rapidapi.com/leagueTable/4");
                request.Method = "GET";

                request.Headers.Add("X-RapidAPI-Key", "e968be4d63mshf39620302037c69p17fed8jsn7bab43a029a9");

                WebResponse imageWebResponse = request.GetResponseAsync().Result;

                // Obtain a 'Stream' object associated with the response object.
                Stream imageStream = imageWebResponse.GetResponseStream();

                // As we are expecting an image response set the encoding to utf-8
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

                // Read the image response
                StreamReader readStream = new StreamReader(imageStream, encode);

                //I am converting the result to string & then i can use for Json Object or anyway i like
                result = readStream.ReadToEnd();

                //Testing data
                //string text = "{\"api\":{\"results\":1,\"standings\":[[{\"rank\":\"1\",\"team_id\":\"50\",\"teamName\":\"Manchester City\",\"matchsPlayed\":\"29\",\"win\":\"23\",\"draw\":\"2\",\"lose\":\"4\",\"goalsFor\":\"76\",\"goalsAgainst\":\"20\",\"goalsDiff\":\"56\",\"points\":\"71\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"2\",\"team_id\":\"40\",\"teamName\":\"Liverpool\",\"matchsPlayed\":\"29\",\"win\":\"21\",\"draw\":\"7\",\"lose\":\"1\",\"goalsFor\":\"64\",\"goalsAgainst\":\"15\",\"goalsDiff\":\"49\",\"points\":\"70\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"3\",\"team_id\":\"47\",\"teamName\":\"Tottenham\",\"matchsPlayed\":\"29\",\"win\":\"20\",\"draw\":\"1\",\"lose\":\"8\",\"goalsFor\":\"56\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"26\",\"points\":\"61\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"4\",\"team_id\":\"33\",\"teamName\":\"Manchester United\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"7\",\"lose\":\"5\",\"goalsFor\":\"58\",\"goalsAgainst\":\"38\",\"goalsDiff\":\"20\",\"points\":\"58\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"5\",\"team_id\":\"42\",\"teamName\":\"Arsenal\",\"matchsPlayed\":\"29\",\"win\":\"17\",\"draw\":\"6\",\"lose\":\"6\",\"goalsFor\":\"61\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"22\",\"points\":\"57\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"6\",\"team_id\":\"49\",\"teamName\":\"Chelsea\",\"matchsPlayed\":\"28\",\"win\":\"17\",\"draw\":\"5\",\"lose\":\"6\",\"goalsFor\":\"49\",\"goalsAgainst\":\"30\",\"goalsDiff\":\"19\",\"points\":\"56\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"7\",\"team_id\":\"39\",\"teamName\":\"Wolves\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"37\",\"goalsAgainst\":\"35\",\"goalsDiff\":\"2\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"8\",\"team_id\":\"38\",\"teamName\":\"Watford\",\"matchsPlayed\":\"29\",\"win\":\"12\",\"draw\":\"7\",\"lose\":\"10\",\"goalsFor\":\"41\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"0\",\"points\":\"43\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"9\",\"team_id\":\"48\",\"teamName\":\"West Ham\",\"matchsPlayed\":\"29\",\"win\":\"11\",\"draw\":\"6\",\"lose\":\"12\",\"goalsFor\":\"37\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-4\",\"points\":\"39\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"10\",\"team_id\":\"45\",\"teamName\":\"Everton\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"7\",\"lose\":\"12\",\"goalsFor\":\"39\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"0\",\"points\":\"37\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"11\",\"team_id\":\"46\",\"teamName\":\"Leicester\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"5\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-6\",\"points\":\"35\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"12\",\"team_id\":\"35\",\"teamName\":\"Bournemouth\",\"matchsPlayed\":\"29\",\"win\":\"10\",\"draw\":\"4\",\"lose\":\"15\",\"goalsFor\":\"39\",\"goalsAgainst\":\"54\",\"goalsDiff\":\"-15\",\"points\":\"34\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"13\",\"team_id\":\"52\",\"teamName\":\"Crystal Palace\",\"matchsPlayed\":\"29\",\"win\":\"9\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"35\",\"goalsAgainst\":\"39\",\"goalsDiff\":\"-4\",\"points\":\"33\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"14\",\"team_id\":\"34\",\"teamName\":\"Newcastle\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"7\",\"lose\":\"14\",\"goalsFor\":\"26\",\"goalsAgainst\":\"36\",\"goalsDiff\":\"-10\",\"points\":\"31\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"15\",\"team_id\":\"51\",\"teamName\":\"Brighton\",\"matchsPlayed\":\"28\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"14\",\"goalsFor\":\"30\",\"goalsAgainst\":\"41\",\"goalsDiff\":\"-11\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"16\",\"team_id\":\"44\",\"teamName\":\"Burnley\",\"matchsPlayed\":\"29\",\"win\":\"8\",\"draw\":\"6\",\"lose\":\"15\",\"goalsFor\":\"32\",\"goalsAgainst\":\"53\",\"goalsDiff\":\"-21\",\"points\":\"30\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"17\",\"team_id\":\"41\",\"teamName\":\"Southampton\",\"matchsPlayed\":\"29\",\"win\":\"6\",\"draw\":\"9\",\"lose\":\"14\",\"goalsFor\":\"32\",\"goalsAgainst\":\"49\",\"goalsDiff\":\"-17\",\"points\":\"27\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"18\",\"team_id\":\"43\",\"teamName\":\"Cardiff\",\"matchsPlayed\":\"29\",\"win\":\"7\",\"draw\":\"4\",\"lose\":\"18\",\"goalsFor\":\"25\",\"goalsAgainst\":\"57\",\"goalsDiff\":\"-32\",\"points\":\"25\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"19\",\"team_id\":\"36\",\"teamName\":\"Fulham\",\"matchsPlayed\":\"29\",\"win\":\"4\",\"draw\":\"5\",\"lose\":\"20\",\"goalsFor\":\"27\",\"goalsAgainst\":\"65\",\"goalsDiff\":\"-38\",\"points\":\"17\",\"lastUpdate\":\"2019-03-03\"},{\"rank\":\"20\",\"team_id\":\"37\",\"teamName\":\"Huddersfield\",\"matchsPlayed\":\"29\",\"win\":\"3\",\"draw\":\"5\",\"lose\":\"21\",\"goalsFor\":\"15\",\"goalsAgainst\":\"51\",\"goalsDiff\":\"-36\",\"points\":\"14\",\"lastUpdate\":\"2019-03-03\"}]]}}";

                // Close all stream
                readStream.Close();
                imageStream.Close();
                imageWebResponse.Close();
            }
            catch (AggregateException e)
            {

            }
            return result;
        }
    }
}

