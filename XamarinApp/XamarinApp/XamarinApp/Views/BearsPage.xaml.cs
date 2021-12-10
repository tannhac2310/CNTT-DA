using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Models;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BearsPage : ContentPage
    {
        public BearsPage()
        {
            InitializeComponent();
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string bearName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

            //
            await Shell.Current.GoToAsync($"beardetails?name={bearName}");

        }
    }
}