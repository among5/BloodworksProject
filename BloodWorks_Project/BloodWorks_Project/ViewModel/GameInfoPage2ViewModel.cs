﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BloodWorks_Project.ViewModel
{
    public class GameInfoPage2ViewModel : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public GameInfoPage2ViewModel()
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