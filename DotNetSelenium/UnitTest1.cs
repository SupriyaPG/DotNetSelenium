using DotNetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

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
            IWebDriver driver = new EdgeDriver();

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
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            driver.Manage().Window.Maximize();
            IWebElement linkText = driver.FindElement(By.LinkText("Login")); //find element
            linkText.Click(); //click element
            IWebElement txtUserName = driver.FindElement(By.Name("UserName")); //find element
            txtUserName.SendKeys("admin");  // send keys
            IWebElement txtPassword = driver.FindElement(By.Name("Password"));
            txtPassword.SendKeys("password");
            IWebElement chkRememerMe = driver.FindElement(By.Id("RememberMe"));
            chkRememerMe.Click();

            IWebElement btnLogin = driver.FindElement(By.Id("loginIn"));
            //btnLogin.Click();
            //or we can use
            btnLogin.Submit();
            driver.Quit();

        }

        [Test]
        public void TestWithPOM()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickLogin();
            loginPage.Login("admin", "password");
        }


        [Test]
        public void websiteLoginTestReducedSizeCode()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Login")).Click(); //find and click the element
            driver.FindElement(By.Name("UserName")).SendKeys("admin"); //find and send keys
            driver.FindElement(By.Name("Password")).SendKeys("password");
            driver.FindElement(By.Id("RememberMe")).Click();
            //driver.FindElement(By.Id("loginIn")).Click();
            //or we can use
            driver.FindElement(By.Id("loginIn")).Submit();

            driver.Quit();
        }

        [Test]
        public void workingWithAdvancedControls()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationintesting.com/selenium/testpage/");
            driver.Manage().Window.Maximize();

            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("gender")));
            selectElement.SelectByText("Male");

            //checking selected element
            IWebElement webElement = selectElement.SelectedOption;
            Console.WriteLine(webElement.Text);

            SelectElement selectMultiElement = new SelectElement(driver.FindElement(By.Id("continent")));
            selectMultiElement.SelectByValue("asia");
            selectMultiElement.SelectByValue("north_america");

            //checking selected options
            IList<IWebElement> selectedOption = selectMultiElement.AllSelectedOptions;

            foreach (var option in selectedOption)
            {
                Console.WriteLine(option.Text);
            }


        }

        [Test]
        public void loginLink()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            IWebElement loginlink = driver.FindElement(By.Id("loginLink"));
            loginlink.Click();

            driver.Quit();

            //Instead of these 2 lines can use following 1 line which is used in a UnitTestUsingCustomMethod

            //SeleniumCustomMethods.click(driver, By.Id("loginLink"));
        }
    }
}