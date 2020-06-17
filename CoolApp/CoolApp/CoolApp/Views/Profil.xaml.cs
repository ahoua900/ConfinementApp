using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Plugin.Media;
using CoolApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profil : ContentPage
    {
        public SQLiteConnection conn;
        public Prof prof;
        public Profil()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Prof>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            prof = new Prof
            {
                Noms = modifNom.Text,
                Email = modifEmail.Text,
                MoPasswords = modifPassword.Text
            };
            conn.Insert(prof);

            modifEmail.Text = "";
            modifEmail.Text = "";
            modifPassword.Text = "";
        }
        private async void Update_Clicked(object sender, EventArgs e)
        {
            var date = (from stu in conn.Table<Prof>() select stu);
            foreach ( var i in date)
            {
                nom.Text = i.Noms;
                email.Text = i.Email;
                pass.Text = i.MoPasswords;
            }
            await DisplayAlert("Félicitation", "Coordonnées modifiées !", "ok");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable && !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Avertissement", "Votre appareil ne supporte pas l'image", "Ok");
                return;

            }
            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            profil.Source = ImageSource.FromStream(() => file.GetStream());
        }
    }
}