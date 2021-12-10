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
    public partial class PokemonsPage : ContentPage
    {
        public PokemonsPage()
        {
            InitializeComponent();
        }

        async private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string PokemonName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;

            await Shell.Current.GoToAsync($"pokemondetails?name={PokemonName}");
        }
    }
}