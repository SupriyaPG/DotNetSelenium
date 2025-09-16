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

         //   Assert.Pass();
        }

        [Test]
        public void websiteLoginTest()
        {
            /* IWebDriver driver = new ChromeDriver();
             driver.Navigate().GoToUrl("http://eaapp.somee.com");
             driver.Manage().Window.Maximize();
             IWebElement linkText = driver.FindElement(By.LinkText("Login"));
             linkText.Click();
             IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
             txtUserName.SendKeys("admin");
             IWebElement txtPassword = driver.FindElement(By.Name("Password"));
             txtPassword.SendKeys("password");
             IWebElement chkRememerMe = driver.FindElement(By.Id("RememberMe"));
             chkRememerMe.Click();   

             IWebElement btnLogin = driver.FindElement(By.Id("loginIn"));
             //btnLogin.Click();
             //or we can use
             btnLogin.Submit();  */

            //can reduse code by using
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Login")).Click(); 
            driver.FindElement(By.Name("UserName")).SendKeys("admin"); 
            driver.FindElement(By.Name("Password")).SendKeys("password");
            driver.FindElement(By.Id("RememberMe")).Click();
            //driver.FindElement(By.Id("loginIn")).Click();
            //or we can use
            driver.FindElement(By.Id("loginIn")).Submit();

            driver.Quit();

        }
    }
}