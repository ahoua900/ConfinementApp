using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cours : ContentPage
    {
        public Cours()
        {
            InitializeComponent();
        }

        private async void Start_Clicked(object sender, EventArgs e)
        {
           await quiz.TranslateTo(0, -200, 100, Easing.Linear);
            await quiz.TranslateTo(0, 0);

            quiz.IsVisible = true;            
            time.Date = DateTime.Now;
            await DisplayAlert("Message", "Le quiz compte pour 2 jours une fois ecoulé il sera fermé", "Merci");
            
            
        }

        private async void End_Clicked(object sender, EventArgs e)
        {
            quiz.IsVisible = false;
            await DisplayAlert("Merci", "votre quiz est envoyé avec succès", "ok");
            await Navigation.PopAsync();
        }
    }
}