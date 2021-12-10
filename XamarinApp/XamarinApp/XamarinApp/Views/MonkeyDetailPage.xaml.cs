using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Entity;
using XamarinApp.Models;

namespace XamarinApp.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Name", "name")]
    public partial class MonkeyDetailPage : ContentPage
    {
        string animals;
        public string Name
        {
            set
            {
                loadAnimal(value);
            }
        }

        private void loadAnimal(string value)
        {
            try
            {
                Animal animal = MonkeyData.Monkeys.FirstOrDefault(m => m.Name == value);
                BindingContext = animal;
                animals = animal.Name;
            }
            catch (Exception)
            {
                Console.WriteLine("Khong the tai!");
            }
        }
        public MonkeyDetailPage()
        {
            InitializeComponent();
            
        }

        public static bool IsUnicode(string input) 
        {
            return Encoding.ASCII.GetByteCount(input) != Encoding.UTF8.GetByteCount(input);
        }

        private void ButtonWebsiteClicked(object sender, EventArgs e)
        {
            string url;
            if (IsUnicode(animals))
            {
                url = "https://vi.wikipedia.org/wiki/" + animals;
            }
            else
            {
                url = "https://en.wikipedia.org/wiki/" + animals;
            }

            Xamarin.Essentials.Launcher.OpenAsync(url);
            
        }
    }
}