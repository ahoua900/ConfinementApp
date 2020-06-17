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
    public partial class Cours : ContentPage
    {
        public Cours()
        {
            InitializeComponent();

            Register Csharp = new Register
            {
                Matiere = "C_sharp xamarin",
                Hour = "15h"

            };
            Register Python = new Register
            {
                Matiere = "Python Django",
                Hour = "20h"

            };
            Register Front = new Register
            {
                Matiere = "Front-End",
                Hour = "15h"

            };
            Register Photshop = new Register
            {
                Matiere = "Multimedia",
                Hour = "20h"

            };
            Register Database = new Register
            {
                Matiere = "Database Base de données",
                Hour = "20h"

            };
            Register Javascript = new Register
            {
                Matiere = "Javascript",
                Hour = "15h"

            };
            Register Flutter = new Register
            {
                Matiere = "Flutter",
                Hour = "15h"

            };

            List<Register> date = new List<Register>() { Flutter, Csharp,Database, Javascript, Front, Photshop };

            Liste.ItemsSource = date;
            Liste.ItemSelected += Liste_ItemSelected;
        }

        private void Liste_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = (Register)e.SelectedItem;
            Navigation.PushAsync(new Matiere(contact));
        }
    }
}