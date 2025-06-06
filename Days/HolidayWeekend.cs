namespace McPlat.Pages
{
    public class HolidayWeekend : WorkDay
    {
        public HolidayWeekend()
        {
            Hours = new List<double>();
        }

        public override double GetPay()
        {
            double clothAddition = 10;
            return AllStats.BasePay * 2 * AllHours + AllHours * clothAddition + (AllStats.BasePay * 0.1 * AllHours);
        }
    }

}
