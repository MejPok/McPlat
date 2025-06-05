namespace McPlat.Pages
{
    public static class AllStats
    {
        public static double BasePay = 133;
        public static Week Week { get; set; } = new Week();

        public static double TotalPay()
        {
            double total = Week.GetPay();
            return total;
        }

    }

}
