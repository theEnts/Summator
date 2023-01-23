using Summator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummatorTests
{
    public class TestSetSummator
    {
        [Test]
        public void Test_SumTwoPositiveNumbers()
        {
            var nums = new[] { 1, 2 };
            var actual = Summator_Class.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SumTwoNegativeNumbers()
        {
            var nums = new[] { -1, -2 };
            var actual = Summator_Class.Sum(nums);

            var expected = -3;

            Assert.AreEqual(expected, actual);
        }
    }
}
