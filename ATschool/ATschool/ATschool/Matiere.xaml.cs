using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATschool.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATschool
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Matiere : ContentPage
    {
        public Matiere(Register oobjet)
        {
            InitializeComponent();
            mat.Text = oobjet.Matiere;
            hou.Text = oobjet.Hour;

            Register theme1 = new Register { Theme = "Introduction", Hour = "30 min" };
            Register theme2 = new Register { Theme = "c# debutant", Hour = "1h30 min" };
            Register theme3 = new Register { Theme = "c# intermediaire", Hour = "2h30 min" };
            Register theme4 = new Register { Theme = "c# avancé", Hour = "1h30 min" };
            Register theme5 = new Register { Theme = "Xamarin forms", Hour = "3h30 min" };

            List<Register> full = new List<Register>() { theme1, theme2, theme3, theme4, theme5 };
            fulle.ItemsSource = full;
            fulle.ItemSelected += Fulle_ItemSelected;
        }

        private void Fulle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var envoie = (Register)e.SelectedItem;
            Navigation.PushAsync(new ViewL(envoie));
        }
    }
}