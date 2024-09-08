using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace TaskManager.Resources.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
    }
}
