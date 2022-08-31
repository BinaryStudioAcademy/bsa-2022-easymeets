namespace EasyMeets.Core.BLL.Helpers
{
    public static class TimeZoneHelper
    {
        public static int MapTimeZoneStringValue(string timeValue)
        {
            var hours = 0;
            var totalMinutes = 0;
            if (Int32.TryParse(timeValue.Substring(0, 3), out hours))
            {
                totalMinutes = hours * 60;
            }
            var minutes = 0;

            if (Int32.TryParse(timeValue.Substring(4, 2), out minutes))
            {
                minutes = minutes == 0 ? minutes : 30;
            }

            totalMinutes = hours > 0 ? totalMinutes + minutes : totalMinutes - minutes;
            return totalMinutes;
        }
    }
}
