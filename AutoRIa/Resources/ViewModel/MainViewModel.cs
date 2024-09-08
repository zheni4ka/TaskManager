using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
namespace TaskManager.Resources.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() 
        {
            Items = new ObservableCollection<string>();
        }


        [ObservableProperty]
        ObservableCollection<string> items;


        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text)) return;

            Items.Add(text);
            Text = string.Empty;
        }


        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s)) { Items.Remove(s); }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}"//,
                //new Dictionary<string, object>
                //{
                //    {nameof(DetailPage), new object()}
                //}
                );

        }

    }
}
