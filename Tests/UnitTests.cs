using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(6, Program.Subtract("12", "6"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("c", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("f", "a"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "8"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(72, Program.Multiply("12", "6"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "d"));
            Assert.Throws<FormatException>(() => Program.Multiply("d", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("d", "y"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("4", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "4"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(3, Program.Divide("3", "1"));
            Assert.AreEqual(12, Program.Divide("72", "6"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "s"));
            Assert.Throws<FormatException>(() => Program.Divide("m", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("n", "w"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(36, Program.Power("6", "2"));
            Assert.AreEqual(100, Program.Power("10", "2"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "q"));
            Assert.Throws<FormatException>(() => Program.Power("q", "9"));
            Assert.Throws<FormatException>(() => Program.Power("q", "i"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
