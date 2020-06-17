using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Plugin.Connectivity;
using Plugin.Media;
using CoolApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Planing : ContentPage
    {
        public SQLiteConnection conn;
        public Publication publication;
        public Nouveau nouveau;
        public Planing()
        {
            InitializeComponent();            
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Publication>();
            conn.CreateTable<Nouveau>();
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Nouveau>() select stu);
            liste.ItemsSource = data;
        }
        private void Pub_Clicked(object sender, EventArgs e)
        {
            pub.IsVisible = true;
        }
        private async void Select_Clicked(object sender, EventArgs e)
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

            ImageR.Source = ImageSource.FromStream(() => file.GetStream());
        }
        private void Take_Clicked(object sender, EventArgs e)
        {
            
        }
        private async void Send_Clicked(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {

                onoff.IsVisible = true;
                pub.IsVisible = false;

                if (nom.Text != null && publi.Text != null)
                {
                    nouveau = new Nouveau
                    {
                        Name = nom.Text,
                        Comment = publi.Text,
                        ImageUrl = Convert.ToString(ImageR.Source)

                    };
                    conn.Insert(nouveau);
                    nom.Text = "";
                    publi.Text = "";
                }
                else
                {
                    await DisplayAlert("Avertissement", "Veuillez remplir tous les champs", "ok");
                }
               
            }
            else
            {
                await DisplayAlert("Avertissement", "Pas de connexion internet ! Veuillez vérifier votre connection", "ok");
            }

        }

        private async void Like_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Félicitation", "Vous avez aimé la publication", "Ok");                                      
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            var date = (from stu in conn.Table<Nouveau>() select stu);
            list.ItemsSource = date;
        }

        
    }
    
}