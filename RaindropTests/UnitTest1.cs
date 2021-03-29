using NUnit.Framework;


namespace RaindropsTests
{
    public class Tests
    {
        [TestCase(3, "Pling")]
        [TestCase(5, "Plang")]
        [TestCase(7, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(21, "PlingPlong")]
        [TestCase(70, "PlangPlong")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(0, "PlingPlangPlong")]
        [TestCase(34, "34")]
        public void WhenAValidIntegerIsPassedToTheMethod_TheCorrectStringIsReturned(int num, string expectedResult)
        {
            var result = RaindropsApp.Program.PlingPlangPlong(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(-3, "Pling")]
        [TestCase(-5, "Plang")]
        [TestCase(-7, "Plong")]
        [TestCase(-30, "PlingPlang")]
        [TestCase(-21, "PlingPlong")]
        [TestCase(-70, "PlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(-34, "-34")]
        public void WhenAValidNegativeIntegerIsPassedToTheMethod_TheCorrectStringIsReturned(int num, string expectedResult)
        {
            var result = RaindropsApp.Program.PlingPlangPlong(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}