using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BloodWorks_Project.ViewModel
{
    public class TheBloodGameViewModel : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public TheBloodGameViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}