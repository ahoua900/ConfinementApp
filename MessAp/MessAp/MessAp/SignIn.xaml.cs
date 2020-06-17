using MessAp.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessAp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        public SQLiteConnection conn;
        public Register register;
        public SignIn()
        {
            InitializeComponent();
               
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var date = (from stu in conn.Table<Register>() select stu);


            if (email.Text != register.Email && Mdpasse.Text != register.Password)
            {

                await DisplayAlert("Erreur", "Identifiant ou mot de passe incorrect", "ok");
            }
            else
            {
                await Navigation.PushAsync(new Menu());
            }

        }
    }
}