using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSelenium
{
    internal class UnitTestUsingCustomMethod
    {
        [Test]
        public void websiteLoginTest_customMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.LinkText("Login")).Click(); //find and click the element
            SeleniumCustomMethods.click(driver, By.Id("loginLink"));

            //driver.FindElement(By.Name("UserName")).SendKeys("admin"); //find and send keys
            SeleniumCustomMethods.EnterText(driver, By.Name("UserName"), "admin");

            //driver.FindElement(By.Name("Password")).SendKeys("password");
            SeleniumCustomMethods.EnterText(driver, By.Name("Password"), "password");

            //driver.FindElement(By.Id("RememberMe")).Click();
            SeleniumCustomMethods.click(driver, By.Id("RememberMe"));

            //driver.FindElement(By.Id("loginIn")).Click();
            //or we can use
            //driver.FindElement(By.Id("loginIn")).Submit();
            SeleniumCustomMethods.click(driver, By.Id("loginIn"));

            driver.Quit();
        }

        [Test]
        public void dropDownByText()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationintesting.com/selenium/testpage/");
            driver.Manage().Window.Maximize();

            // SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("gender")));
            //selectElement.SelectByText("Male");

            SeleniumCustomMethods.SelectDropDownByText(driver, By.Id("gender"), "Male");

            /*SelectElement selectMultiElement = new SelectElement(driver.FindElement(By.Id("continent")));
            selectMultiElement.SelectByValue("asia");
            selectMultiElement.SelectByValue("north_america"); */

            SeleniumCustomMethods.SelectMultiDropDown(driver, By.Id("continent"), ["asia", "north_america"]);
            var list = SeleniumCustomMethods.GetAllSelectedLists(driver, By.Id("continent"));

            /* foreach (var listItem in list)
             { 
                 Console.WriteLine(listItem);
             } */
            //ne w code for foreach loop is
            list.ForEach(Console.WriteLine);  //just one line code

            driver.Quit();
        }
    }
}
