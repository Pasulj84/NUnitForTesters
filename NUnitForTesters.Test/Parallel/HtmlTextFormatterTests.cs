using NUnit.Framework;
using NUnitForTesters.Parallel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitForTesters.Test.Parallel
{
    internal class HtmlTextFormatterTests
    {
        private HtmlTextFormatter _htmlt;

        [SetUp]
        public void Setup()
        {
            _htmlt = new HtmlTextFormatter();
        }

        [Test]
        public void StriT1()
        {
            string s = _htmlt.FormatAsBold("Dominik");
            Assert.AreEqual("<b>Dominik</b>", s);
        }

        [Test]
        public void StriT2()
        {
            string s = _htmlt.FormatAsItalic("Dominik");
            Assert.AreEqual("<i>Dominik</i>", s);
        }

        [Test]
        public void StriT3()
        {
            string s = _htmlt.FormatAsSmall("Dominik");
            Assert.AreEqual("<small>Dominik</small>", s);
        }

        [Test]
        public void StriT4()
        {
            string s = _htmlt.FormatAsDeleted("Dominik");
            Assert.AreEqual("<del>Dominik</del>", s);
        }

        [Test]
        public void StriT5()
        {
            string s = _htmlt.FormatAsSubscript("Dominik");
            Assert.AreEqual("<sub>Dominik</sub>", s);
        }

        [Test]
        public void StriT6()
        {
            string s = _htmlt.FormatAsCustomTag("Dominik", "dd");
            Assert.AreEqual("<dd>Dominik</dd>", s);
        }

        [TestCase("Sprawdzam", "Sprawdzam2", "<Sprawdzam2>Sprawdzam</Sprawdzam2>")]
        public void StriT7(string name, string tag, string result)
        {
            string s = _htmlt.FormatAsCustomTag(name, tag);
            Assert.AreEqual(result, s);
        }

        [TestCase("Sprawdzam", "Sprawdzam2")]
        public void StriT8(string name, string tag)
        {
            string s = _htmlt.FormatAsCustomTag(name, tag);
            Assert.AreEqual($"<{tag}>{name}</{tag}>", s);
        }
    }
}
