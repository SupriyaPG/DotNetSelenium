using DotNetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    internal class POMTest
    {
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
        public void WorkingGendorDropDown()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationintesting.com/selenium/testpage/");
            driver.Manage().Window.Maximize();

            //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("gender")));
            //selectElement.SelectByText("Male");
            TestFormPage formPage = new TestFormPage(driver);
            formPage.GendorDropDown("Male");

         
        }

        [Test]
        public void VisitedContinent()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://automationintesting.com/selenium/testpage/");
            driver.Manage().Window.Maximize();

            TestFormPage testFormPage = new TestFormPage(driver);
            testFormPage.SelectedContinant();
        }
    }
}
