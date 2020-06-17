using OpenData.Vues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OpenData
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Orga_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Organisation());
        }

        private async void Res_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ressource());
        }
        private async void Them_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thematique());
        }
    }
}
