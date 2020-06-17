using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppElie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chart : MasterDetailPage
    {
        public Chart()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Page1());
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page3());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page4());
        }

       
    }
}