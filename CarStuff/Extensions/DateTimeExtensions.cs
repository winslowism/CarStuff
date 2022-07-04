namespace CarStuff.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime RandomBetween(this DateTime startDate, DateTime endDate)
        {
            var randomTest = new Random();

            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, randomTest.Next(0, (int)timeSpan.TotalMinutes), 0);
            DateTime newDate = startDate + newSpan;
            return newDate;
        }
    }
}
