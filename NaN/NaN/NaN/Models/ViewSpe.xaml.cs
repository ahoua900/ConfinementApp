using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaN.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaN.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSpe : ContentPage
    {
        public ViewSpe(Special objet)
        {
            InitializeComponent();
            titre.Text = objet.Title;
            image.Source = objet.ImageUrl;
            theme.Text = objet.Theme;
            descri.Text = objet.Description;
            lecon.Text = objet.Lecon;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            cour.IsVisible = true;           
            cour.TranslateTo(0, -100, 100, Easing.Linear);
            cour.TranslateTo(0, 0);


        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            
            await DisplayAlert("Avertissement", "Le cours sera fermé ! Avez vous finis ?", "Ok");
            
                cour.IsVisible = false;
                die.IsVisible = true;
            
            
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cours());
        }
    }
}