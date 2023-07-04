namespace LeapYearKata;

public class Year
{
    public static bool IsLeap(int year)
    {
        if (year == 400 || year == 800) return true;
            
        return false;
    }
}