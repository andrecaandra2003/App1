using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace App1.ViewModels
{
    public partial class PacientiListViewModels : ObservableObject
    {
        [ICommand]
        public async void AddUpdateClienti()
        {
            // Presupunând că ai o rută definită pentru "AddUpdateClientiPage"
            await Shell.Current.GoToAsync(nameof(AddUpdateClienti));
        }
    }
}
