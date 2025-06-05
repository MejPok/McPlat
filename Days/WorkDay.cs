namespace McPlat.Pages
{
    public abstract class WorkDay
    {
        public List<double> Hours {  get; set; }
        public double AllHours
        {
            get
            {
                double allhours = 0;

                foreach (double doub in Hours)
                {
                    allhours += doub;
                }
                return allhours;
            }
        }
        public abstract double GetPay();

    }

}
