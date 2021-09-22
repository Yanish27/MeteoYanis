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


        public MainWindow()
        {

            InitializeComponent();
            string[] Villes = new string[] { "ANNECY", "PARIS", "LYON" };
            string API_KEY = "b190a0605344cc4f3af08d0dd473dd25";
            string API_USAGE = "&appid=" + API_KEY;
            string API_LINK = "https://api.openweathermap.org/data/2.5/weather?q=" + API_USAGE;
            
            foreach (string value in Villes)
            {
                ComboVille.Items.Add(value);
            }

            HttpClient client = new HttpClient();
            var stringTask = client.GetStringAsync(API_LINK + "ANNECY" + API_USAGE);
            /* str stringTask.Result */

/* https://json2csharp.com/  && http://json.parser.online.fr/ */

/* {"coord":{"lon":6.1167,"lat":45.9},"weather":[{"id":804,"main":"Clouds","description":"overcast clouds","icon":"04d"}],"base":"stations","main":{"temp":288.59,"feels_like":288.2,"temp_min":283.05,"temp_max":296.5,"pressure":1026,"humidity":77},"visibility":10000,"wind":{"speed":5.14,"deg":60},"clouds":{"all":90},"dt":1632304316,"sys":{"type":1,"id":6500,"country":"FR","sunrise":1632288149,"sunset":1632332043},"timezone":7200,"id":6455254,"name":"Annecy","cod":200} */
}
}
}
