using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.Net.Http;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

/* https://openweathermap.org/current yanishalaoui js*/
namespace MeteoYanis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }

        public class Clouds
        {
            public int all { get; set; }
        }

        public class Sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class Root
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public string @base { get; set; }
            public Main main { get; set; }
            public int visibility { get; set; }
            public Wind wind { get; set; }
            public Clouds clouds { get; set; }
            public int dt { get; set; }
            public Sys sys { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
        public async Task<string> GetApi(string ville)
        {

            string API_KEY = "b190a0605344cc4f3af08d0dd473dd25&units=metric&lang=fr";
            string API_USAGE = "&appid=" + API_KEY;
            string API_LINK = "https://api.openweathermap.org/data/2.5/weather?q=";

            HttpClient client = new HttpClient();
            HttpResponseMessage reponse = await client.GetAsync(API_LINK + ville + API_USAGE);
            if (reponse.IsSuccessStatusCode)
            {
                var content = await reponse.Content.ReadAsStringAsync();

                Root API_Meteo = JsonConvert.DeserializeObject<Root>(content);
                var NuagePourcent = API_Meteo.clouds.all;
                var CoordonnesLat = API_Meteo.coord.lat;
                var CoordonnesLon = API_Meteo.coord.lon;
                var Pays = API_Meteo.sys.country;
                var LeveSoleil = API_Meteo.sys.sunrise;
                var CoucheSoleil = API_Meteo.sys.sunset;
                var humidite = API_Meteo.main.humidity;
                var temp = API_Meteo.main.temp;
                var ressenti = API_Meteo.main.feels_like;
                var vent = API_Meteo.wind.speed;
                string min = "";
                if (UnixTimeStampToDateTime(CoucheSoleil).Minute.ToString().Length == 1)
                {
                    min = "0" + UnixTimeStampToDateTime(CoucheSoleil).Minute.ToString();
                } else
                {
                    min = UnixTimeStampToDateTime(CoucheSoleil).Minute.ToString();
                }
                LabelCoucheSoleil.Content = UnixTimeStampToDateTime(CoucheSoleil).Hour + ":" + min;

                /* --- */ 
                if (UnixTimeStampToDateTime(LeveSoleil).Minute.ToString().Length == 1)
                {
                    min = "0" + UnixTimeStampToDateTime(LeveSoleil).Minute.ToString();
                }
                else
                {
                    min = UnixTimeStampToDateTime(LeveSoleil).Minute.ToString();
                }
                LabelLeveSoleil.Content = UnixTimeStampToDateTime(LeveSoleil).Hour + ":" + min;


                LabelHum.Content = humidite + "%";
                LabelTemp.Content = temp + " °C";
                LabelTempRESSENTI.Content = ressenti + " °C";
                LabelVent.Content = vent + "km/h";
                
                if (API_Meteo.weather[0].description == "partiellement nuageux" || API_Meteo.weather[0].description == "nuageux")
                {
                    ImgLabel.Source = new BitmapImage(new Uri(@"C:\Users\SIO2\source\MeteoYanis\MeteoYanis\nuage.png", UriKind.RelativeOrAbsolute));
                }
                else if (API_Meteo.weather[0].description == "ciel dégagé")
                {
                    ImgLabel.Source = new BitmapImage(new Uri(@"C:\Users\SIO2\source\MeteoYanis\MeteoYanis\soleil.png", UriKind.RelativeOrAbsolute));
                }
                    return null;
            }
            else
            {
                return null;
            }
        }

        public MainWindow()
        {

            InitializeComponent();
            string[] Villes = new string[] { "ANNECY", "PARIS", "LYON", "LILLE"};

            foreach (string value in Villes)
            {
                ComboVille.Items.Add(value);
            }
            ComboVille.SelectedIndex = 0;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var x = GetApi(Convert.ToString(ComboVille.SelectedItem));
        }
    }
}
