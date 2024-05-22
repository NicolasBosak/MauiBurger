using MauiBurger.Models;
using Newtonsoft.Json;
namespace MauiBurger
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7208/api/");
            var response = client.GetAsync("burger").Result;
            if (response.IsSuccessStatusCode)
            {
                var burgers = response.Content.ReadAsStringAsync().Result;
                var burgersList =
               JsonConvert.DeserializeObject<List<Burger>>(burgers);
                listView.ItemsSource = burgersList;
            }
        }

    }

}
