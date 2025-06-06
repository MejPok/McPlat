namespace McPlat.Pages
{
    public static class AllStats
    {
        public static double BasePay = 133;
        public static Week Week { get; set; } = new Week();
        public static Weekend Weekend { get; set; } = new Weekend();
        public static Holiday Holiday { get; set; } = new Holiday();
        public static HolidayWeekend HolidayWeekend { get; set; } = new HolidayWeekend();

        public static double TotalPay()
        {
            double total = Week.GetPay() + Weekend.GetPay();

            return total;
        }

    }

}
