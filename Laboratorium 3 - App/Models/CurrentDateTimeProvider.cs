namespace Laboratorium_3___App.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
