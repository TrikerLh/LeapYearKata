namespace LeapYearKata;

public class Year
{
    public static bool IsLeap(int year)
    {
        if (year % 400 == 0) return true;
            
        return false;
    }
}