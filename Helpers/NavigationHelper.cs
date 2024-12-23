using OpenQA.Selenium;
using System.Runtime.CompilerServices;

namespace DemoQA.Helpers
{
    internal class NavigationHelper
    {
        private const string HomepageUrl = "https://demoqa.com/";

        public static void OpenHomepage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(HomepageUrl);
        }

        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
