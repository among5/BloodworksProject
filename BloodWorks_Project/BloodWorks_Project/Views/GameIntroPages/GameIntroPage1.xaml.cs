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

    public partial class GameIntroPage1 : ContentPage
    {
        GameIntroPage1ViewModel viewModel;

        public GameIntroPage1(GameIntroPage1ViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public GameIntroPage1()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);

            await Navigation.PushAsync(new GameIntroPage2(new GameIntroPage2ViewModel()));
        }

    }
}