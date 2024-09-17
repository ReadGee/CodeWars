using System;
using NUnit.Framework;

namespace NUnitTest
{
    class TitleCase
    {
        [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
        [TestCase("aBC deF Ghi", null, "Abc Def Ghi")]
        public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
        {
            Assert.That(expected, Is.EqualTo(Code.Code.C_TitleCase.TitleCase(sampleTitle, sampleMinorWords)));
        }
        [Test]
        public void MyTest2()
        {
            Assert.That("", Is.EqualTo(Code.Code.C_TitleCase.TitleCase("")));
        }
        [Test]
        public void MyTest3()
        {
            Assert.That("The Quick Brown Fox", Is.EqualTo(Code.Code.C_TitleCase.TitleCase("the quick brown fox")));
        }
    }
}
