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
    public partial class Messagerie : ContentPage
    {
        public SQLiteConnection conn;
        public  Register register ;
        public Messagerie()
        {
            InitializeComponent();

           
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Register>() select stu);
            
        }

        private void FromList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = (Register)e.SelectedItem;

            Navigation.PushAsync(new Profil(contact));
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new DeletePage());

        }

       
    }
}
