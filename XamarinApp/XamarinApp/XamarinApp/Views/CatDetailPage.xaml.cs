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
    [QueryProperty(nameof(Name), "name")]
    public partial class CatDetailPage : ContentPage
    {
        string animals;

        public string Name
        {
            set
            {
                LoadAnimal(value);
            }
        }

        public CatDetailPage()
        {
            InitializeComponent();
        }

        void LoadAnimal(string name)
        {
            try
            {
                Animal animal = CatData.Cats.FirstOrDefault(a => a.Name == name);
                BindingContext = animal;
                animals = animal.Name;
                
            }
            catch (Exception)
            {
                Console.WriteLine("Khong tai duoc!");
            }
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
                url = "https://vi.wikipedia.org/wiki/" + animals +" cat";
            }
            else
            {
                url = "https://en.wikipedia.org/wiki/" + animals + " cat";
            }

            //Device.OpenUri(new Uri(url));
            Xamarin.Essentials.Launcher.OpenAsync(url);

        }
    }
}