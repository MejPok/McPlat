using McPlat.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace McPlat.Pages
{
    /// <summary>
    /// Interakční logika pro Finance.xaml
    /// </summary>
    public partial class Finance : Page
    {
        VMFinance vm;
        public Finance()
        {
            InitializeComponent();
            vm = new VMFinance();
            vm.CurrentMonthPay = AllStats.TotalPay() + "";
            vm.Savings = "0";
            vm.LeftAccount = "0";
            this.DataContext = vm;
        }
    }
}
