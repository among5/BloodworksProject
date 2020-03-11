using BloodWorks_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace BloodWorks_Project.Views
{
    [DesignTimeVisible(false)]
    public partial class TheBloodGame : ContentPage
    {
        TheBloodGameViewModel viewModel;

        public TheBloodGame(TheBloodGameViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public TheBloodGame()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5000);
            await Navigation.PushAsync(new GameInfoPage1(new GameInfoPage1ViewModel()));
        }

    }
}