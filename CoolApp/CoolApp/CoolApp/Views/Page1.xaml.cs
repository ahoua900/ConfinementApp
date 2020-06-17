using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                not.IsVisible = false;
                await Navigation.PushAsync(new Popup());
            }
            else
            {
               await not.TranslateTo(100, 0, 200, Easing.Linear);
               await not.TranslateTo(0, 0);
                not.IsVisible = true;
            }
           
        }
    }
}