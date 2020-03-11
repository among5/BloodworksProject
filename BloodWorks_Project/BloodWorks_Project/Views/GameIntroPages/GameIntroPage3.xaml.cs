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

    public partial class GameIntroPage3 : ContentPage
    {
        GameIntroPage3ViewModel viewModel;

        public GameIntroPage3(GameIntroPage3ViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public GameIntroPage3()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(3000);

            await Navigation.PushAsync(new GameIntroPage4(new GameIntroPage4ViewModel()));
        }

    }
}