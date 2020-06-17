using OpenData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenData.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewThe : ContentPage
    {
        public ViewThe(Thematque objet)
        {
            InitializeComponent();

            title.Text = objet.title;
            descri.Text = objet.description;
        }
    }
}