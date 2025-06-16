using McPlat.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace McPlat.Pages
{
    /// <summary>
    /// Interakční logika pro MonthPayPage.xaml
    /// </summary>
    public partial class MonthPayPage : Page
    {
        VMMonthPay vm;
        public MonthPayPage()
        {
            InitializeComponent();
            vm = new VMMonthPay(WeekList, WeekendList, HolidayList, HolidayWeekendList);
            this.DataContext = vm;

        }

        

        private void WeekHoursAdd(object sender, RoutedEventArgs e)
        {
            string hoursString = vm.Week.Hours;

            if(double.TryParse(hoursString, out double hours))
            {
                WeekList.Items.Add(hours);
                AllStats.Week.Hours.Add(hours);
            }

            vm.Change();

        }

        private void WeekendHoursAdd(object sender, RoutedEventArgs e)
        {
            string hoursString = vm.Weekend.Hours;

            if (double.TryParse(hoursString, out double hours))
            {
                WeekendList.Items.Add(hours);
                AllStats.Weekend.Hours.Add(hours);
            }

            vm.Change();
        }

        private void HolidayHoursAdd(object sender, RoutedEventArgs e)
        {
            string hoursString = vm.Holiday.Hours;

            if (double.TryParse(hoursString, out double hours))
            {
                HolidayList.Items.Add(hours);
                AllStats.Holiday.Hours.Add(hours);
            }

            vm.Change();
        }
        private void HolidayWeekendHoursAdd(object sender, RoutedEventArgs e)
        {
            string hoursString = vm.HolidayWeekend.Hours;

            if (double.TryParse(hoursString, out double hours))
            {
                HolidayWeekendList.Items.Add(hours);
                AllStats.HolidayWeekend.Hours.Add(hours);
            }

            vm.Change();
        }
    }

}
