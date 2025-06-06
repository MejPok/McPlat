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
        ListView weekList;
        ListView weekendList;
        ListView holidayList;
        ListView holidayWeekendList;
        public VMMonthPay(ListView _weekList, ListView _weekendList, ListView _holidayList, ListView _holidayWeekendList) {
            weekList = _weekList;
            weekendList = _weekendList;
            holidayList = _holidayList;
            holidayWeekendList = _holidayWeekendList;

            Week = new VMWeek();
            Weekend = new VMWeek();
            Holiday = new VMWeek();
            HolidayWeekend = new VMWeek();

            Setup();
        }

        public VMWeek Week { get; set; }
        public VMWeek Weekend { get; set; }
        public VMWeek Holiday { get; set; }
        public VMWeek HolidayWeekend { get; set; }

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


        void Setup()
        {
            foreach (double item in AllStats.Week.Hours)
            {
                weekList.Items.Add(item);
            }
            foreach (double item in AllStats.Weekend.Hours)
            {
                weekendList.Items.Add(item);
            }
            foreach (double item in AllStats.Holiday.Hours)
            {
                holidayList.Items.Add(item);
            }
            foreach (double item in AllStats.HolidayWeekend.Hours)
            {
                holidayWeekendList.Items.Add(item);
            }

            Change();
        }

        public void Change()
        {
            AllPay = AllStats.TotalPay() + "";
            Week.Pay = AllStats.Week.GetPay() + "";
            Week.HoursIn = AllStats.Week.AllHours + "";
            
            Weekend.Pay = AllStats.Weekend.GetPay() + "";
            Weekend.HoursIn = AllStats.Weekend.AllHours + "";

            Holiday.Pay = AllStats.Holiday.GetPay() + "";
            Holiday.HoursIn = AllStats.Holiday.AllHours + "";

            HolidayWeekend.Pay = AllStats.HolidayWeekend.GetPay() + "";
            HolidayWeekend.HoursIn = AllStats.HolidayWeekend.AllHours + "";
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new
           PropertyChangedEventArgs(propertyName));
        }
    }



    public class VMWeek : INotifyPropertyChanged {
        private string _Hours;
        public string Hours
        {
            get => _Hours;
            set
            {
                if (_Hours != value)
                {
                    _Hours = value;
                    OnPropertyChanged(nameof(Hours));
                }
            }
        }

        private string _Pay;
        public string Pay
        {
            get => _Pay;
            set
            {
                if (_Pay != value)
                {
                    _Pay = value;
                    OnPropertyChanged(nameof(Pay));
                }
            }
        }



        private string _HoursIn;
        public string HoursIn
        {
            get => _HoursIn;
            set
            {
                if (_HoursIn != value)
                {
                    _HoursIn = value;
                    OnPropertyChanged(nameof(HoursIn));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new
           PropertyChangedEventArgs(propertyName));
        }

    }

}
