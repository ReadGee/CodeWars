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

    class Diamond
    {
        [TestCase(3)]
        [TestCase(8)]
        [TestCase(5)]
        [TestCase(2)]
        public void MyTest(int n)
        {
            if (n % 2 == 0 || n < 1)
            {
                Assert.That(Code.Code.Diamond.print(n), Is.Null);
                Console.WriteLine("Null");
            }
            else
            {
                Assert.That(Code.Code.Diamond.print(n), Is.Not.Null);
                Console.WriteLine(Code.Code.Diamond.print(n));
            }
        }
    }
    class Your_order__please
    {
        [TestCase("is2 Thi1s T4est 3a", "Thi1s is2 3a T4est")]
        [TestCase("4of Fo1r pe6ople g3ood th5e the2", "Fo1r the2 g3ood 4of th5e pe6ople")]
        public void MyTest(string inText, string outText)
        {
            Assert.That(outText, Is.EqualTo(Code.Code.Your_order__please.Order(inText)));
            Console.WriteLine(Code.Code.Your_order__please.Order(inText));
        }
    }
}
