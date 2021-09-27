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
            var stringTask = client.GetStringAsync(API_LINK + "PARIS " + API_USAGE);
            /* str stringTask.Result */

            /* https://json2csharp.com/  && http://json.parser.online.fr/ */

            /* {"coord":{"lon":6.1167,"lat":45.9},"weather":[{"id":804,"main":"Clouds","description":"overcast clouds","icon":"04d"}],"base":"stations","main":{"temp":288.59,"feels_like":288.2,"temp_min":283.05,"temp_max":296.5,"pressure":1026,"humidity":77},"visibility":10000,"wind":{"speed":5.14,"deg":60},"clouds":{"all":90},"dt":1632304316,"sys":{"type":1,"id":6500,"country":"FR","sunrise":1632288149,"sunset":1632332043},"timezone":7200,"id":6455254,"name":"Annecy","cod":200} */



}
}
}
