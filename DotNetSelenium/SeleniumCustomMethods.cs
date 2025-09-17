using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium
{
    public class SeleniumCustomMethods
    {
        //Method should get the method
        //Start getting the type of identifier
        //perform operation on the locator 
        public static void click(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }

        public static void EnterText(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }

        public static void SelectDropDownByText(IWebDriver driver, By locator, string text)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByText(text);
            IWebElement webElement = selectElement.SelectedOption;
            Console.WriteLine(webElement.Text);
        }

        public static void SelectDropDownByValue(IWebDriver driver, By locator, string value)
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByValue(value);
        }

        public static void SelectMultiDropDown(IWebDriver driver, By locator, String[] Values)
        {
            SelectElement selectMultiElement = new SelectElement(driver.FindElement(locator));
            //selectMultiElement.SelectByText(Array);

            foreach (var option in Values)
            {
                selectMultiElement.SelectByValue(option);
            }
        }

        public static List<string> GetAllSelectedLists(IWebDriver driver, By locator)
        {
            List<string> result = new List<string>();
            SelectElement multiSelect = new SelectElement(driver.FindElement(locator));
            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;

            foreach (var option in selectedOption)
            {
                result.Add(option.Text);
            }
            return result;
        }
    }
}
