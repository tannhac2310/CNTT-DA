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
    public partial class DogsPage : ContentPage
    {
        public DogsPage()
        {
            InitializeComponent();
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string dogName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

            await Shell.Current.GoToAsync($"dogdetails?name={dogName}");
        }
    }
}