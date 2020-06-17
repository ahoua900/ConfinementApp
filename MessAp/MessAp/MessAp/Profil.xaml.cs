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
    public partial class Profil : ContentPage
    {
        public SQLiteConnection conn;
        public Register register;
        public Profil(Register objets)
        {
            InitializeComponent();

            UserPro.Text = objets.User;
            EmailPro.Text = objets.Email;
            PassPro.Text = objets.Password;

        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Modif());
            
        }
    }
}