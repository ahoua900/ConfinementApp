using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HOtelAPpl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Acceuil : ContentPage
    {
        public Acceuil()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Passage());
        }

     private async  void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nuit());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sejour());
        }

        private async  void Button_Clicked_3(object sender, EventArgs e)
        {
         await Navigation.PushAsync(new Reserver());
        }

        private async  void Show_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registers());
        }
    }
}