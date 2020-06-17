using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HOtelAPpl
{
    public partial class App : Application
    {
        public static string FilePath { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
