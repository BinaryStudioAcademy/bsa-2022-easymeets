namespace EasyMeets.Core.BLL.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime Format(this DateTime dateTime, string format)
        {
            return DateTime.Parse(dateTime.ToString(format));
        }
    }
}
