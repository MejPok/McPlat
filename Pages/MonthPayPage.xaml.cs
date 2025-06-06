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
            WeekList.Items.Add(vm.Week.Hours);
            AllStats.Week.Hours.Add(double.Parse(vm.Week.Hours));

            vm.Change();

        }

        private void WeekendHoursAdd(object sender, RoutedEventArgs e)
        {
            WeekendList.Items.Add(vm.Weekend.Hours);
            AllStats.Weekend.Hours.Add(double.Parse(vm.Weekend.Hours));

            vm.Change();
        }

        private void HolidayHoursAdd(object sender, RoutedEventArgs e)
        {
            HolidayList.Items.Add(vm.Holiday.Hours);
            AllStats.Holiday.Hours.Add(double.Parse(vm.Holiday.Hours));

            vm.Change();
        }
        private void HolidayWeekendHoursAdd(object sender, RoutedEventArgs e)
        {
            HolidayWeekendList.Items.Add(vm.HolidayWeekend.Hours);
            AllStats.HolidayWeekend.Hours.Add(double.Parse(vm.HolidayWeekend.Hours));

            vm.Change();
        }
    }

}
