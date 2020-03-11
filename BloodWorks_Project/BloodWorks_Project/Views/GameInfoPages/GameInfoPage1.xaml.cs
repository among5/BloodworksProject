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
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class GameInfoPage1 : ContentPage
    {
        GameInfoPage1ViewModel viewModel;

        public GameInfoPage1(GameInfoPage1ViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public GameInfoPage1()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);

            await Navigation.PushAsync(new GameInfoPage2(new GameInfoPage2ViewModel()));
        }

    }
}