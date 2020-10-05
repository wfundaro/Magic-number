using nombremagique.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nombremagique
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GamePage();
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
