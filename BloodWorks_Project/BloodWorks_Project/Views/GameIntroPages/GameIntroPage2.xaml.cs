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

    public partial class GameIntroPage2 : ContentPage
    {
        GameIntroPage2ViewModel viewModel;

        public GameIntroPage2(GameIntroPage2ViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public GameIntroPage2()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);

            await Navigation.PushAsync(new GameIntroPage3(new GameIntroPage3ViewModel()));
        }

    }
}