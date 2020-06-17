using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Applical
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Save : ContentPage
    {
        List<int> Notes = new List<int>() { };
        public Save()
        {
            InitializeComponent();
            
        }

       async  private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Voir());
        }
    }
}