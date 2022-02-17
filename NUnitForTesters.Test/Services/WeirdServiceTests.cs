using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    internal class WeirdServiceTests
    {
        private WeirdService _ime;

        [SetUp]
        public void Setup()
        {
            _ime = new WeirdService();
        }

        [Test, Retry(4)]
        public void TestBB()
        {
            int result = _ime.ThisMethodWillPassSometimes();
            Assert.That(result, Is.LessThanOrEqualTo(1000));

        }
    }
}
