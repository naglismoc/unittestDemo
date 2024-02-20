
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
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //driver = new ChromeDriver(options);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://skelbiu.lt");
            driver.FindElement(By.XPath("//*[@id=\"onetrust-accept-btn-handler\"]")).Click();
            driver.FindElement(By.Id("searchKeyword")).SendKeys("distiliatorius");
            driver.FindElement(By.Id("searchButton")).Click();
            string text = driver.FindElement(By.XPath("//*[@id=\"ads68011637\"]/div[2]/div[2]/div[2]")).Text;
            Console.WriteLine(text);
        }


        [TearDown]
        public void TearDown()
        {
            // driver.Quit();
        }
    }
}