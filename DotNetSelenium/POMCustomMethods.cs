using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium
{
    public class POMCustomMethods
    {
        public static void Click(IWebElement locator)
        {
            locator.Click();
        }

        public static void Submit(IWebElement locator)
        {
            locator.Submit();
        }
       
        public static void EnterText(IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownByText(IWebElement locator, string text)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
            IWebElement webElement = selectElement.SelectedOption;
            Console.WriteLine(webElement.Text);
        }

        public static void SelectDropDownByValue(IWebElement locator, string value)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByValue(value);
        }

        public static void SelectMultiDropDown(IWebElement locator, String[] Values)
        {
            SelectElement selectMultiElement = new SelectElement(locator);
            //selectMultiElement.SelectByText(Array);

            foreach (var option in Values)
            {
                selectMultiElement.SelectByValue(option);
            }
        }

        public static List<string> GetAllSelectedLists(IWebElement driver, By locator)
        {
            List<string> result = new List<string>();
            SelectElement multiSelect = new SelectElement(locator);
            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;

            foreach (var option in selectedOption)
            {
                result.Add(option.Text);
            }
            return result;
        }
    }
}
