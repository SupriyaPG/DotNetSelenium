using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Create a new instance of selenium Web driver
            IWebDriver driver = new ChromeDriver();

            //Navigate to the URL
            driver.Navigate().GoToUrl("https://www.google.com/");

            //Maximise the URL window
            driver.Manage().Window.Maximize();

            //find the element
            IWebElement webElement = driver.FindElement(By.Name("q"));

            //Type in the element
            webElement.SendKeys("Selenium");

            //Click on the element
            webElement.SendKeys(Keys.Return);

            driver.Quit();

            Assert.Pass();
        }
    }
}