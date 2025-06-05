using McPlat.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McPlat.ViewModel
{
    internal class VMMainPage : INotifyPropertyChanged
    {
        public double currentMonthPay { get; set; } = AllStats.TotalPay();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new
           PropertyChangedEventArgs(propertyName));
        }

    }
}
