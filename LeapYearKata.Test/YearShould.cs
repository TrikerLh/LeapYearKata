namespace LeapYearKata.Test
{
    public class YearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Return_true_with_year_400()
        {
            bool result = Year.IsLeap(400);
            Assert.AreEqual(true, result);
        }
    }

    public class Year
    {
        public static bool IsLeap(int year)
        {
            if (year == 400) return true;
            
            return false;
        }
    }
}