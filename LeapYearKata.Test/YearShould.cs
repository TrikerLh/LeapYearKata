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
            var result = Year.IsLeap(400);
            Assert.That(result, Is.EqualTo(true));
        }
    }
}