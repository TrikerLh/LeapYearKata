namespace LeapYearKata;

public class Year
{
    public static bool IsLeap(int year)
    {
        var result = (year % 4 == 0 &&  year % 100 != 0) || year % 400 == 0;
        return result;
    }
}