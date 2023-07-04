namespace LeapYearKata;

public class Year
{
    public static bool IsLeap(int year)
    {
        if (year % 400 == 0) return true;
        if (year % 100 == 0 && year % 400 != 0) return false;
        if (year == 4) return true;
        return false;
    }
}