using NUnit.Framework;
using System;

namespace TestGithubActions.UnitTests
{
    public class MathTests
    {
        private MyMath _math;

        [SetUp]
        public void SetUp()
        {
            _math = new MyMath();
        }

        [Test]
        public void Sq_2_returns4()
        {
            var result = _math.Sqr(2);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Sq_3_returns9()
        {
            var result = _math.Sqr(3);

            Assert.AreEqual(9, result);
        }
    }
}
