using DemoApp.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace DemoApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestPrintGreeting_NamePrintedCorrectly()
        {
            using (var sw = new StringWriter())
            {
                System.Console.SetOut(sw);
                Program.PrintGreeting("John");
                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains("Hello, John!!"));
            }
        }

        [TestMethod]
        public void TestPrintGreeting_LetterCountCorrect()
        {
            using (var sw = new StringWriter())
            {
                System.Console.SetOut(sw);
                Program.PrintGreeting("John");
                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains("Your name has 4 letters."));
            }
        }
    }
}