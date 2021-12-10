using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Models;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElephantsPage : ContentPage
    {
        public ElephantsPage()
        {
            InitializeComponent();
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ElephantName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

            await Shell.Current.GoToAsync($"elephantdetails?name={ElephantName}");
        }

    }
}