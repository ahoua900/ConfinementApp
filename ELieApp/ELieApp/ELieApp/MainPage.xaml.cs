using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ELieApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Page1());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page3());
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page4());
        }
    }
}
