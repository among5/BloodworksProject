using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BloodWorks_Project.Views;


namespace BloodWorks_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IntroPage());
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
