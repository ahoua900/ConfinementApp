using SQLite;
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
    public partial class Nuit : ContentPage
    {
        public SQLiteConnection conn;
        public Sudent student;
        public Nuit()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Sudent>();
        }

       async private void Button_Clicked(object sender, EventArgs e)
        {

            if (heureEntree.Text != null && heureSortie.Text != null && cmb.Text != null)
            {
                student = new Sudent
                {
                    Entrée = heureEntree.Text,
                    Sortie = heureSortie.Text,
                    Chambre = Convert.ToInt32(cmb.Text)

                };
                conn.Insert(student);

                await DisplayAlert("Felicitation", "Nuit enregistré avec succes", "Ok");
                
            }
            else
            {
                await DisplayAlert("Erreur", "Les champs ne doivent pas etre vides", "Ok");
            }
        }

        private void Vue_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = true;
            var dates = (from stu in conn.Table<Sudent>() select stu);

            amour.ItemsSource = dates;
        }
        private void Close_Clicked(object sender, EventArgs e)
        {
            list.IsVisible = false;
        }
    }
}