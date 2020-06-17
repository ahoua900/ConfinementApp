using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenData.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenData.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Thematique : ContentPage
    {
        public Thematique()
        {
            InitializeComponent();

            GetThematque();
        }

        private  void GetThematque()
        {
            HttpClient client = new HttpClient();

            var reponse =  client.GetStringAsync("http://data.gouv.ci/api/thematics").Result;

            var Organ = JsonConvert.DeserializeObject<List<Thematque>>(reponse);

            listview.ItemsSource = Organ;
            listview.ItemSelected += Listview_ItemSelected;
        }
        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = (Thematque)e.SelectedItem;
            Navigation.PushAsync(new ViewThe(contact));
        }
    }
}