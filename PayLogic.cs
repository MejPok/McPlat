using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McPlat
{
    internal class PayLogic
    {
       static double CalculateHourlyWageForDay(string day, double baseHourPay = 133)
        {
            double WeekendAllowance = 0.1;
            double HolidayAllowance = 1;

            double clothAddition = 10;
            double WeekendAddition = baseHourPay * WeekendAllowance;
            double HolidayAddition = baseHourPay * HolidayAllowance;

            if (day == "week")
            {

                return baseHourPay + clothAddition;

            }
            else if (day == "weekend")
            {

                return baseHourPay + clothAddition + WeekendAddition;

            }
            else if (day == "holiday")
            {

                return baseHourPay + clothAddition + HolidayAddition;
            }
            else if (day == "holidayWeekend")
            {
                return baseHourPay + clothAddition + HolidayAddition + WeekendAddition;

            }

            throw new Exception("Issue selecting workday");
        }

        public static  (decimal, decimal, decimal) SpendPerDay(decimal money, decimal days, int save, decimal amountLeft)
        {
            decimal moneyAllowed = money;

            decimal saved = moneyAllowed * save / 100;
            moneyAllowed -= saved;
            moneyAllowed -= amountLeft;
            decimal spendperday = moneyAllowed / days;
            (decimal, decimal, decimal) result = (spendperday, saved, amountLeft);
            return result;
        }
    }
}
