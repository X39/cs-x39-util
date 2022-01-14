namespace X39.Util;

public static class DateTimeExtensionMethods
{
    public static DateOnly ToDateOnly(this DateTime dateTime)
    {
        return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
    }
    public static TimeOnly ToTimeOnly(this DateTime dateTime)
    {
        return new TimeOnly(dateTime.Hour, dateTime.Minute, dateTime.Second);
    }
}