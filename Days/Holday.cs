namespace McPlat.Pages
{
    public class Holiday : WorkDay
    {
        public Holiday()
        {
            Hours = new List<double>();
        }

        public override double GetPay()
        {
            double clothAddition = 10;
            return AllStats.BasePay * 2 * AllHours + AllHours * clothAddition;
        }
    }

}
