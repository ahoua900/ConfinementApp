using CoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup : ContentPage
    {
        public SQLiteConnection conn;
        public Inscription inscription;
        public Popup()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Inscription>();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (email.Text != null && Mdp != null)
            {
                await DisplayAlert("Félicitation", "Vous etes connecté", "ok");
                await Navigation.PushAsync(new MainPage());
                /* var dete = (from stu in conn.Table<Inscription>() select stu);
                 foreach (var item in dete)
                 {
                     if (email.Text == item.Email && Mdp.Text == item.MotDePasse)
                     {
                         await DisplayAlert("Félicitation", "Vous etes connecté", "ok");
                         await Navigation.PopAsync();
                     }
                     else
                     {
                         await DisplayAlert("Avertissement", "Pas encore inscrit", "ok");
                     }
                 }*/
            }
            else
            {
               await DisplayAlert("Avertissement", "Veuillez remplir les champs", "ok");
            }
        }
        private  void Log_Clicked(object sender, EventArgs e)
        {
            nom.IsVisible = true;
            ConfMdp.IsVisible = true;
            login.Text = "Inscrivez-Vous !";
            log.IsVisible = false;
            loge.IsVisible = true;
            logs.IsVisible = false;

            
        }
        private async  void But_Clicked(object sender, EventArgs e)
        {
            if (nom.Text != null && Mdp != null && email.Text != null && ConfMdp != null)
            {
                inscription = new Inscription
                {
                    Email = email.Text,
                    Names = nom.Text,
                    MotDePasse = Mdp.Text
                };
                conn.Insert(inscription);
                email.Text = "";
                Mdp.Text = "";
                nom.Text = "";

                await DisplayAlert("Félicitation", "Vous etes inscrit", "ok");

                nom.IsVisible = false;
                ConfMdp.IsVisible = false;
                login.Text = "Conectez-Vous !";
                log.Text = "Connexion";
                logs.IsVisible = true;

                /*var dete = (from stu in conn.Table<Inscription>() select stu);
                foreach (var item in dete)
                {
                    if (nom.Text != item.Names && Mdp.Text != item.MotDePasse && email.Text != item.Email)
                    {
                        inscription = new Inscription
                        {
                            Email = email.Text,
                            Names = nom.Text,
                            MotDePasse = Mdp.Text
                        };
                        conn.Insert(inscription);
                        email.Text = "";
                        Mdp.Text = "";
                        nom.Text = "";

                        await DisplayAlert("Félicitation", "Vous etes inscrit", "ok");

                        nom.IsVisible = false;
                        ConfMdp.IsVisible = false;
                        login.Text = "Conectez-Vous !";
                        log.Text = "Connexion";
                        logs.IsVisible = true;
                    }
                    else
                    {
                      await  DisplayAlert("Avertissement", "Déja inscrit", "ok");
                    }
                }*/
            }
            else
            {
               await DisplayAlert("Avertissement", "Veuillez remplir les champs", "ok");
            }
        }
    }
}