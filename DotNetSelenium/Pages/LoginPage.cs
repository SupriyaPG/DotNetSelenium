using OpenQA.Selenium;

namespace DotNetSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        }

        IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));
        IWebElement TxtUserNmae => driver.FindElement(By.Id("UserName")); 
        IWebElement TxtPassword=>driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));


        public void ClickLogin()
        {
            // LoginLink.Click();
            POMCustomMethods.Click(LoginLink);
        }                                                 
        public void Login(string username, string password)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        {
            // TxtUserName.SendKeys(username);
            POMCustomMethods.EnterText(TxtUserNmae,username);
            //TxtPassword.SendKeys(password);
            POMCustomMethods.EnterText(TxtPassword,password);
            POMCustomMethods.Submit(BtnLogin);                                                                                                                       
        }
    }
}
