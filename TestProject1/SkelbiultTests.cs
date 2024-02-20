
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public class Tests
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://skelbiu.lt");
        }


        [TearDown]
        public void TearDown()
        {
            // driver.Quit();
        }
    }
}