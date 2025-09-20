using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium.Pages
{
    public class TestFormPage
    {
        private readonly IWebDriver driver;

        public TestFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement gendorElement => driver.FindElement(By.Id("gender"));
        IWebElement continentElement => driver.FindElement(By.Id("continent"));


        public void GendorDropDown(string gendor)
        {
            SelectElement selectElement = new SelectElement(gendorElement);
            selectElement.SelectByText(gendor);

            //checking selected element
            IWebElement webElement = selectElement.SelectedOption;
            Console.WriteLine(webElement.Text);


        }


        public void SelectedContinant()
        {
            SelectElement selectMultiElement = new SelectElement(continentElement);
            selectMultiElement.SelectByValue("asia");
            selectMultiElement.SelectByValue("north_america");

            //checking selected options
            IList<IWebElement> selectedOption = selectMultiElement.AllSelectedOptions;

            foreach (var option in selectedOption)
            {
                Console.WriteLine(option.Text);
            }
        }
    }
}
