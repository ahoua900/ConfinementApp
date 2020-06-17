using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaN.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NaN.Data;

namespace NaN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        public SQLiteConnection conn;
        public Student student;
        public SignIn()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Student>();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            if (nom.Text != null && email.Text != null && spe.Text != null && code.Text != null && mdp.Text != null)
            {
                student = new Student
                {
                    Name = nom.Text,
                    Email = email.Text,
                    Spécialité = spe.Text,
                    Code = code.Text,
                    Password = mdp.Text
                };

                var Data = (from stu in conn.Table<Student>() select stu);
                foreach (var item in Data)
                {
                    if (nom.Text == item.Name && email.Text == item.Email && spe.Text == item.Spécialité && mdp.Text == item.Password)
                    {
                        await DisplayAlert("Avertissement", "Personne déja inscrite !", "Ok");
                        
                    }
                    else
                    {
                        conn.Insert(student);
                        nom.Text = "";
                        email.Text = "";
                        spe.Text = "";
                        code.Text = "";
                        mdp.Text = "";
                        await DisplayAlert("Felicitation", "Votre inscription a été prise en compte", "Ok");
                    }
                }
                

            }
            else
            {
                await DisplayAlert("Erreur", "Veuillez remplir tous les champs", "Ok");
            }
        }

        async private void Go_Clicked(object sender, EventArgs e)
        {
            if ( email.Text != null && spe.Text != null && mdp.Text != null)
            {
                var Data = (from stu in conn.Table<Student>() select stu);
                foreach (var item in Data)
                {
                    if (email.Text == item.Email && spe.Text == item.Spécialité && mdp.Text == item.Password)
                    {
                        await DisplayAlert("Felicitation", "connexion reussie !", "Ok");
                        await Navigation.PushAsync(new Specialités());
                    }
                    else
                    {
                        await DisplayAlert("Désolé", "Pas encore inscrit !", "Reprendre");
                    }
                }

            }
            else
            {
                await DisplayAlert("Erreur", "Veuillez remplir tous les champs", "Ok");
            }
        }

        private async void List_Clicked(object sender, EventArgs e)
        {
            log.Text = "Inscription";
            vue.IsVisible = true;
            await vue.TranslateTo(0, 100, 200, Easing.Linear);
            await vue.TranslateTo(0, 0);
            vues.IsVisible = true;
            await vues.TranslateTo(0, -100, 100, Easing.Linear);
            await vues.TranslateTo(0, 0);
            cone.IsVisible = false;
            ins.IsVisible = true;
            list.IsVisible = false;
        }
    }
}