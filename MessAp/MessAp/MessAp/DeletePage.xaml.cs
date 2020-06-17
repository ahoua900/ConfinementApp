using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MessAp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessAp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePage : ContentPage
    {
        public SQLiteConnection conn;
        public Register register;
        public DeletePage()
        {
            InitializeComponent();
        }

    private void FromList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        register = (Register)e.SelectedItem;
    
    }
    private async void Deletes_Clicked(object sender, EventArgs e)
        {

            conn.Table<Register>().Delete(x => x.Id == register.Id);
           await DisplayAlert("Avertissement", "Voulez vous suprimer l'inscription", "ok");
           await Navigation.PopAsync();
        }
        
    }
}