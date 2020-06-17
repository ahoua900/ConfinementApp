using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using SQLite;
using CoolApp.Models;
using Xamarin.Forms.Xaml;

namespace CoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Message : ContentPage
    {
        public SQLiteConnection conn;
        public Messenger messenger;

        public Message()
        {
            InitializeComponent();
            conn = DependencyService.Get<Isqlite>().GetConnection();
            conn.CreateTable<Messenger>();

            var datet = (from stu in conn.Table<Messenger>() select stu);
            Sende.ItemsSource = datet;
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            send.IsVisible = true;

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (cont.Text != null && mess.Text != null)
            {
                messenger = new Messenger
                {
                    Contact = cont.Text,
                    Message = mess.Text
                };
                conn.Insert(messenger);
                cont.Text = "";
                mess.Text = "";

                send.IsVisible = false;

                var datet = (from stu in conn.Table<Messenger>() select stu);
                Sende.ItemsSource = datet;
                Sende.ItemSelected += Sende_ItemSelected;

            }
            else
            {
                await DisplayAlert("Avertissement", "Veuillez remplir les champs ", "ok");
            }
        }

        private void Sende_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var content = (Messenger)e.SelectedItem;
            Navigation.PushAsync(new ViewMes(content));
        }
    }
}