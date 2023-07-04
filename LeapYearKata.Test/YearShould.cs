namespace LeapYearKata.Test
{
    public class YearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(400)]
        [TestCase(800)]
        [TestCase(1200)]
        public void Return_true_with_year_divisible_400(int input)
        {
            var result = Year.IsLeap(input);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Return_false_year_100()
        {
            var result = Year.IsLeap(100);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void Return_false_year_200()
        {
            var result = Year.IsLeap(200);
            Assert.That(result, Is.EqualTo(false));
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        public void Return_false_with_year_divisible_100_but_not_divisible_400(int input)
        {
            var result = Year.IsLeap(input);
            Assert.AreEqual(false, result);
        }
    }
}