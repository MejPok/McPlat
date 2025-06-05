using McPlat.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace McPlat.ViewModel
{
    internal class VMMonthPay: INotifyPropertyChanged
    {
        ListView view;
        public VMMonthPay(ListView _view) {
            view = _view;
            Setup();
        }

        private string _weekHours;
        public string WeekHours
        {
            get => _weekHours;
            set
            {
                if (_weekHours != value)
                {
                    _weekHours = value;
                    OnPropertyChanged(nameof(WeekHours));
                }
            }
        }

        private string _allPay;
        public string AllPay
        {
            get => _allPay;
            set
            {
                if (_allPay != value)
                {
                    _allPay = value;
                    OnPropertyChanged(nameof(AllPay));
                }
            }
        }



        private string _weekPay;
        public string WeekPay
        {
            get => _weekPay;
            set
            {
                if (_weekPay != value)
                {
                    _weekPay = value;
                    OnPropertyChanged(nameof(WeekPay));
                }
            }
        }



        private string _weekHoursIn;
        public string weekHoursIn
        {
            get => _weekHoursIn;
            set
            {
                if (_weekHoursIn != value)
                {
                    _weekHoursIn = value;
                    OnPropertyChanged(nameof(weekHoursIn));
                }
            }
        }

        void Setup()
        {
            foreach (double item in AllStats.Week.Hours)
            {
                view.Items.Add(item);
            }

            Change();
        }

        public void Change()
        {
            AllPay = AllStats.TotalPay() + "";
            WeekPay = AllStats.Week.GetPay() + "";
            weekHoursIn = AllStats.Week.AllHours + "";
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new
           PropertyChangedEventArgs(propertyName));
        }
    }
}
