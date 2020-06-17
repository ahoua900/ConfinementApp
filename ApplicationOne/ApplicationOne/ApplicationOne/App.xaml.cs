using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApplicationOne
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =  new NavigationPage(new ApplicationOne.MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
