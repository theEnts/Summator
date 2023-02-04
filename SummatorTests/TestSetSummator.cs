using Newtonsoft.Json.Linq;
using NUnit.Framework.Constraints;
using Summator;
using System.Collections;

namespace SummatorTests
{
    public class TestSetSummator
    {
        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator_Methods.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_Two_Negative_Numbers()
        {
            var nums = new int[] { -1, -2 };
            var actual = Summator_Methods.Sum(nums);

            var expected = -3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_One_Positive_Number()
        {
            var nums = new int[] { 2 };
            var actual = Summator_Methods.Sum(nums);

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_Zero_Number()
        {
            var nums = new int[] { };
            var actual = Summator_Methods.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_Big_Number()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator_Methods.Sum(nums);

            var expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_Positive_Number()
        {
            var nums = new double[] { 6, 9, 8 };
            var actual = Summator_Methods.Average(nums);

            var expected = 7.67;

            actual = Math.Round(actual, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_With_Negative_Number()
        {
            var nums = new double[] { 6, 9, 8, -7.9 };
            var actual = Summator_Methods.Average(nums);

            var expected = 3.78;

            actual = Math.Round(actual, 2);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Multiply_With_Two_Numbers()
        {
            var nums = new int[] { 8, 4 };
            int actual = (int)Summator_Methods.Multiplication(nums);
            var expected = 32;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Power_Of_Two_Numbers()
        {
            var nums = new double[] { 5, 2 };
            double actual = Summator_Methods.PowerOfNumbers(nums);
            double expected = 25;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Division_Of_Two_Numbers()
        {
            var nums = new int[] { 25, 5 };
            double actual = Summator_Methods.Divide(nums);
            double expected = 5;

            Assert.AreEqual(expected, actual);
        }


        // DDT Test Cases
        [TestCase(new int[] { 5, 2 }, 7)]
        [TestCase(new int[] { -5, 2 }, -3)]
        [TestCase(new int[] { -3, -3 },-6)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] {}, 0)]
        public void Test_Summator_SumDDT(int[] values, long expected)
        {
            var actual = Summator_Methods.Sum(values);

            Assert.AreEqual(expected, actual);
        }
    }
}
