using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace McPlat.ViewModel
{
    internal class VMFinance : INotifyPropertyChanged
    {
        string _currentMonthPay = "0";

        public string CurrentMonthPay
        {
            get => _currentMonthPay;
            set
            {
                if (_currentMonthPay != value)
                {
                    _currentMonthPay = value;
                    OnPropertyChanged(nameof(CurrentMonthPay));
                }
            }
        }

        string _Savings = "0";

        public string Savings
        {
            get => _Savings;
            set
            {
                if (_Savings != value)
                {
                    _Savings = value;
                    OnPropertyChanged(nameof(Savings));
                }
            }
        }

        string _LeftAccount = "0";

        public string LeftAccount
        {
            get => _LeftAccount;
            set
            {
                if (_LeftAccount != value)
                {
                    _LeftAccount = value;
                    OnPropertyChanged(nameof(LeftAccount));
                }
            }
        }

        string _SpendDaily = "0";

        public string SpendDaily
        {
            get => _SpendDaily;
            set
            {
                if (_SpendDaily != value)
                {
                    _SpendDaily = value;
                    OnPropertyChanged(nameof(SpendDaily));
                }
            }
        }

        string _ActaullySaved = "0";

        public string ActaullySaved
        {
            get => _ActaullySaved;
            set
            {
                if (_ActaullySaved != value)
                {
                    _ActaullySaved = value;
                    OnPropertyChanged(nameof(ActaullySaved));
                }
            }
        }




        public double ChosenPay()
        {
            return double.Parse(CurrentMonthPay);
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var s = SafeParse();
            SpendDaily = s.Item1 + "";
            ActaullySaved = s.Item2 + "";

            PropertyChanged?.Invoke(this, new
           PropertyChangedEventArgs(propertyName));
        }

        (decimal, decimal, decimal) SafeParse()
        {
            if (decimal.TryParse(CurrentMonthPay, out var d)) {
                if(int.TryParse(Savings, out int save))
                {
                    if(decimal.TryParse(LeftAccount, out decimal left))
                    {
                        return PayLogic.SpendPerDay(d, 30, save, left);
                    }
                    
                }
            
            
            }

            return (0, 0, 0);
        }
    }
}
