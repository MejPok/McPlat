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
            vm = new VMMonthPay(WeekList);
            this.DataContext = vm;

        }



        private void WeekHoursAdd(object sender, RoutedEventArgs e)
        {
            WeekList.Items.Add(vm.Week.Hours);
            AllStats.Week.Hours.Add(double.Parse(vm.Week.Hours));

            vm.Change();

        }
    }

}
