using OpenQA.Selenium;

namespace DemoQA.Contexts
{
    public class ElementsContext
    {
        private Dictionary<string, By> Locators { get; } = [];

        public void AddLocator(string name, By locator)
        {
            Locators[name] = locator;
        }

        public By GetLocator(string name)
        {
            if (Locators.TryGetValue(name, out var locator))
            {
                return locator;
            }
            throw new KeyNotFoundException($"No locator found for key '{name}'");
        }

        public IWebElement GetElement(IWebDriver driver, string key)
        {
            var locator = GetLocator(key);
            var element = driver.FindElement(locator);

            return element;
        }
    }
}
