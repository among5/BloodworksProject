using BloodWorks_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BloodWorks_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroPage : ContentPage
    {
        IntroPageViewModel viewModel;
        public IntroPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new IntroPageViewModel();
        }

        async void OnScreenSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            //var item = (Item)layout.BindingContext;
            await Navigation.PushAsync(new TheBloodGame(new TheBloodGameViewModel()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items != null && !viewModel.Items.Any())
                viewModel.IsBusy = true;
        }

    }
}