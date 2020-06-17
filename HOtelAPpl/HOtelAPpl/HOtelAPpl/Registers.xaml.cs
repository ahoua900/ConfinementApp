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
    public partial class Registers : ContentPage
    {
        public SQLiteConnection conn;
        public Sudent student;
        public Sejournée sejours;
        public Review review;
        public Finité fini;
        public Registers()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.Table<Finité>();
            conn.Table<Sejournée>();
            conn.Table<Sudent>();
            conn.Table<Review>();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Acceuil());
        }
       

        private void Passe_Clicked(object sender, EventArgs e)
        {
            var date = (from stu in conn.Table<Review>() select stu);

            amour.ItemsSource = date;
        }
        private void Nuit_Clicked(object sender, EventArgs e)
        {
            var dates = (from stu in conn.Table<Sudent>() select stu);

            amour.ItemsSource = dates;
        }
        private void Sej_Clicked(object sender, EventArgs e)
        {
            var dat = (from stu in conn.Table<Sejournée>() select stu);

            amour.ItemsSource = dat;
        }
        private void Res_Clicked(object sender, EventArgs e)
        {
            var dote = (from stu in conn.Table<Finité>() select stu);

            amour.ItemsSource = dote;
        }

    }
}