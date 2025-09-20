using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    // public class POMCustomMethods
    public static class POMCustomMethods //for extension method class should be static
    {
        //Method should get locator
        //start getting the type of identifier
        //perform operations on locator

        public static void ClickElement(this IWebElement locator)
        {
            locator.Click();
        }


        public static void SubmitElement(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownByText(this IWebElement locator, string text)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
            IWebElement webElement = selectElement.SelectedOption;
            Console.WriteLine(webElement.Text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, string value)
        {
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByValue(value);
        }

        public static void SelectMultiDropDown(this IWebElement locator, String[] Values)
        {
            SelectElement selectMultiElement = new SelectElement(locator);
            //selectMultiElement.SelectByText(Array);

            foreach (var option in Values)
            {
                selectMultiElement.SelectByValue(option);
            }
        }

        public static List<string> GetAllSelectedLists(this IWebElement locator)
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
