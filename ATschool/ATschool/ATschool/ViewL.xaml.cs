using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATschool.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATschool
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewL : ContentPage
    {
        public ViewL( Register objet)
        {
            InitializeComponent();
            mat.Text = objet.Theme;
            hou.Text = objet.Hour;
        }
    }
}