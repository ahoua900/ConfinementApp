using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using MessAp.Data;

namespace MessAp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public SQLiteConnection conn;
        public Register register;
        public MainPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Register>();
                
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            

            if (nom.Text != null && email.Text != null && Mdpasse.Text != null)
            {
                register = new Register();
                register.Id = Convert.ToInt32(code.Text);
                register.User = nom.Text ;
                register.Email = email.Text;
                register.Password = Mdpasse.Text;

                conn.Insert(register);
                code.Text = "";
                nom.Text = "";
                email.Text = "";
                Mdpasse.Text = "";

                await DisplayAlert("Felicitations", "Inscrit avec succes consultez vos Entrées en cliquant sur APERCU ", "ok");

            }
            else
            {
                await DisplayAlert("Erreur", "Veuillez renseigner les champs vides", "ok");
            }

        }

        private void Show_Clicked(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Register>() select stu);

            FromList.ItemsSource = data;

            FromList.ItemSelected += FromList_ItemSelected;
        
      }
        private void FromList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = (Register)e.SelectedItem;

            Navigation.PushAsync(new Profil(contact));
        }

        private async  void Update_Clicked(object sender, EventArgs e)
        {
            if (! string.IsNullOrEmpty(code.Text))
            {
                register = new Register();
                register.Id = Convert.ToInt32(code.Text);
                register.User = nom.Text;
                register.Email = email.Text;
                register.Password = Mdpasse.Text;

                conn.Update(register);

                code.Text = "";
                nom.Text = "";
                email.Text = "";
                Mdpasse.Text = "";

                await DisplayAlert("Avertissment", " le Profil  sera mit a jour !", "ok");

                var data = (from stu in conn.Table<Register>() select stu);

                data.Select<>
                FromList.ItemsSource = data;
                
            }
            
        }
        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var datas = (from stu in conn.Table<Register>() select stu.Id);
            if (datas != null)
            {

                conn.Delete(register);
                code.Text = "";
                await DisplayAlert("Avertissment", " le Profil sera suprimé !", "ok");

                var data = (from stu in conn.Table<Register>() select stu);

                FromList.ItemsSource = data;
                

            }
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new SignIn());
        }
        
        
    }
}
