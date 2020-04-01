using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Module7_TP04.services;

namespace Xamarin_Module7_TP04
{
    public partial class App : Application
    {
        private ITwitterService tweeterService = new TwitterService();
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
