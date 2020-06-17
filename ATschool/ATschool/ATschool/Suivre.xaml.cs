using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATschool
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Suivre : ContentPage
    {
        public Suivre()
        {
            InitializeComponent();
        }

        private async void Anonyme_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cours());
        }

        private async void Compte_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignIn());

        }
    }
}