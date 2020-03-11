using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using BloodWorks_Project.Views;

namespace BloodWorks_Project.ViewModel
{
    public class IntroPageViewModel : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
      


        //public IntroPageViewModel()
        //{
        //    async Task ExecuteLoadItemsCommand()
        //    {
        //        IsBusy = true;

        //        try
        //        {
        //            Items.Clear();
        //            var items = await DataStore.GetItemsAsync(true);
        //            foreach (var item in items)
        //            {
        //                Items.Add(item);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex);
        //        }
        //        finally
        //        {
        //            IsBusy = false;
        //        }
        //    }
        //}
    }
}