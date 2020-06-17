using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenData.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenData.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewOr : ContentPage
    {
        public ViewOr(Organisatio objet)
        {
            InitializeComponent();

            title.Text = objet.name;
            descri.Text = objet.description;
            web.Text = objet.website;
            tel.Text = objet.phone;
            email.Text = objet.email;

        }
    }
}