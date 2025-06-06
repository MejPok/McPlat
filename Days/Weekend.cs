namespace McPlat.Pages
{
    public class Weekend : WorkDay
    {
        public Weekend()
        {
            Hours = new List<double>();
        }

        public override double GetPay()
        {
            double clothAddition = 10;
            return AllStats.BasePay * AllHours + AllHours * clothAddition + (AllStats.BasePay * 0.1 * AllHours);
        }
    }

}
