using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HOtelAPpl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Passage : ContentPage
    {
        public SQLiteConnection conn;
        public Review review;
        public Passage()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Review>();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            if (heureEntree.Text != null && heureSortie.Text != null && cmb.Text != null)
            {
                review = new Review
                {
                    Entrée = heureEntree.Text,
                    Sortie = heureSortie.Text,
                    Chambre = Convert.ToInt32(cmb.Text)

                };
                conn.Insert(review);

                await DisplayAlert("Felicitation", "Passage enregistré avec succes", "Ok");
                
            }
            else
            {
                await DisplayAlert("Erreur", "Les champs ne doivent pas etre vides", "Ok");
            }
           
        }

        private void Vue_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = true;

            var date = (from stu in conn.Table<Review>() select stu);

            amour.ItemsSource = date;
        }
        private void Close_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = false;
        }
    }
}