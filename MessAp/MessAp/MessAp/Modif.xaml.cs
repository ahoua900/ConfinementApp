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
    public partial class Modif : ContentPage
    {
        public SQLiteConnection conn;
        public Register register;
        public Modif()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            register = new Register();
            register.User = UserM.Text;
            register.Email = EmailM.Text;
            register.Password = MdpasseM.Text;

            conn.Update(register);
            Navigation.PopAsync();
        }
    }
}