using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Models;

namespace XamarinApp.Services
{
    public class AnimalSearchHandler : SearchHandler
    {
        //Tạo ra 2 đối tượng là list animal và tạo targetitem Navigation
        public IList<Animal> Animals { get; set; }
        public Type SelectedItemNavigationTarget { get; set; }
        Random namerd = new Random();


        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            //string textrd = Convert.ToString((char)namerd.Next(97, 122));
            if (string.IsNullOrWhiteSpace(newValue))
            {

                ItemsSource = null;
            }
            else
            {
                //Sử dụng linq để query ra con vật cần search
                ItemsSource = Animals
                    .Where(animal => animal.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList<Animal>();
            } 
                
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            //Hoàn thành hiển thị ảnh
            await Task.Delay(1000);

            
            //
            await Shell.Current.GoToAsync($"{GetNavigationTarget()}?name={((Animal)item).Name}");


        }

        private object GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
            
        }
    }
   
}

//ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;