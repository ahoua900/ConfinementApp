using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OpenData.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace OpenData.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Organisation : ContentPage
    {
        public Organisation()
        {
            InitializeComponent();

            GetOrganisatio();
        }

        private void GetOrganisatio()
        {
            HttpClient client = new HttpClient();

            var reponse =  client.GetStringAsync("http://data.gouv.ci/api/organizations").Result;
            

            var Organ = JsonConvert.DeserializeObject<List<Organisatio>>(reponse);

            listview.ItemsSource = Organ;
            


            listview.ItemSelected += Listview_ItemSelected;
        }

        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = (Organisatio)e.SelectedItem;
            Navigation.PushAsync(new ViewOr(contact));
        }
    }
}