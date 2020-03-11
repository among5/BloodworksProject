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
    public partial class GameInfoPage2 : ContentPage
    {
        GameInfoPage2ViewModel viewModel;


        public GameInfoPage2(GameInfoPage2ViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

             public GameInfoPage2()
        {
            InitializeComponent();
        }

        //To next page on tap       
        async void OnScreenSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            await Navigation.PushAsync(new GameIntroPage3(new GameIntroPage3ViewModel()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items != null && !viewModel.Items.Any())
                viewModel.IsBusy = true;
        }
    }
}