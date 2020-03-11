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
    }
}