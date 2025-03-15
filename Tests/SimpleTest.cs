using NUnit.Framework;

namespace SauceDemoAutomation.Tests.TestSuites
{
    [TestFixture]
    public class SimpleTest
    {
        [Test]
        public void SimplePassingTest()
        {
            Assert.Pass("Проект успешно настроен!");
        }
    }
}