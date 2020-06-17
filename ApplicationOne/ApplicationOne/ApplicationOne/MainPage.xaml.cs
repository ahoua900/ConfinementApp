using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApplicationOne
{
   
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

       async private void Button_Clicked(object sender, EventArgs e)
        {
            var name = "laroche";
            var penom = "élie";
            var email = "laroche@gmail.com";
            var mdp = 1234;
            var cnfMdp = 1234;
            try
            {
                
               
                    if (Regex.IsMatch(name,nom.Text))
                    {
                        await Navigation.PushAsync(new Page1()); 

                    }
                    else
                    {
                        labelName.Text = "is not your name please retry";
                    }

                    if (Regex.IsMatch(penom, prenom.Text))
                    {
                        await Navigation.PushAsync(new Page1());

                    }
                    else
                    {
                        LabelPre.Text = "is not your surname please retry";
                    }
                    if (Regex.IsMatch(email, emaile.Text))
                    {

                        await Navigation.PushAsync(new Page1());
                    }
                    else
                    {
                        labelEm.Text = "is not your email please retry";
                    }
                    var pass = Convert.ToInt32(password.Text);
                    if (mdp == pass)
                    {
                        await Navigation.PushAsync(new Page1());

                    }
                    else
                    {
                        labelPass.Text = "is not your password please retry";
                    }
                    var cnfpass = Convert.ToInt32(cnfPassword.Text);
                    if (cnfMdp == cnfpass)
                    {
                        await Navigation.PushAsync(new Page1());
                    }
                    else
                    {
                        labelPasscnf.Text = "is not your same password please retry";
                    }
                    
                   
                
                     
                
            }
            catch 
            {

                Console.WriteLine("verifiez vos entrees");
            }

           
        }
    }
}
