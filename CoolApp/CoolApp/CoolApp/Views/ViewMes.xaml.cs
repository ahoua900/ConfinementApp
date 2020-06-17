using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewMes : ContentPage
    {
        public ViewMes(Messenger objet)
        {
            InitializeComponent();

            conte.Text = objet.Contact;
            messa.Text = objet.Message;

        }
    }
}