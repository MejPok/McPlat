namespace McPlat.Pages
{
    public class Week : WorkDay
    {
        public Week()
        {
            Hours = new List<double>();
        }

        public override double GetPay()
        {
            double clothAddition = 10;
            return AllStats.BasePay * AllHours + AllHours * clothAddition;
        }
    }

}
