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
    public partial class Reserver : ContentPage
    {
        public SQLiteConnection conn;
        public Finité fini;
        public Reserver()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Finité>();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if (heureEntree.Text != null && heureSortie.Text != null && cmb.Text != null)
            {
                fini = new Finité
                {
                    Types = type.Text, 
                    Entrée = heureEntree.Text,
                    Sortie = heureSortie.Text,
                    Chambre = Convert.ToInt32(cmb.Text)

                };
                conn.Insert(fini);

                await DisplayAlert("Felicitation", "Réservation enregistré avec succes", "Ok");
               
            }
            else
            {
                await DisplayAlert("Erreur", "Les champs ne doivent pas etre vides", "Ok");
            }
        }

        private void Vue_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = true;
            var dote = (from stu in conn.Table<Finité>() select stu);

            amour.ItemsSource = dote;
        }
        private void Close_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = false;
        }
    }
}