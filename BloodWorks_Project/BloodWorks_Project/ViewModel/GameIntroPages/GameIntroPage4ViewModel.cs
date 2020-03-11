using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BloodWorks_Project.ViewModel
{
    public class GameIntroPage4ViewModel : ContentPage
    {
        public GameIntroPage4ViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Testing" }
                }
            };
        }
    }
}