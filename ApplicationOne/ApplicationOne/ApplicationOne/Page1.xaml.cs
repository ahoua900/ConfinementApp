using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApplicationOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

       async private void Button_Clicked(object sender, EventArgs e)
        {
            var email = "laroche@gmail.com";
            var mdp = 1234;
            var pass = Convert.ToInt32(password.Text);
            if (email != emaile.Text)
            {

                labelEm.Text = "is not your email please retry";
            }
            else if(mdp != pass)
            {
                labelPass.Text = "is not your password please retry";
            }
           
            else
            {
                await Navigation.PushAsync(new Page2());
            }
        }
    }
}