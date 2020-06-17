using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace HOtelAPpl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sejour : ContentPage
    {
        public SQLiteConnection conn;
        public Sejournée sejours;
        public Sejour()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Sejournée>();

        }

         private async void Button_Clicked(object sender, EventArgs e)
        {
            if (enter.Text != null &&  exit.Text != null && chamb.Text != null)
            {
                sejours = new Sejournée()
                {
                    Entrée = enter.Text,
                    Sortie = exit.Text,
                    Chambre = Convert.ToInt32(chamb.Text),
                    piece = Convert.ToInt32(piece.Text)

                };
                conn.Insert(sejours);

                await DisplayAlert("Felicitation", "Sejour enregistré avec succes", "Ok");
                
            }
            else
            {
                await DisplayAlert("Erreur", "Les champs ne doivent pas etre vides", "Ok");
            }



        }
        private void Vue_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = true;
            var dat = (from stu in conn.Table<Sejournée>() select stu);

            amour.ItemsSource = dat;
        }
        private void Close_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = false;
        }
    }
}