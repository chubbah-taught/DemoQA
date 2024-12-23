using OpenQA.Selenium;

namespace DemoQA.Contexts
{
    public class ElementsContext
    {
        public Dictionary<string, IWebElement> Elements { get; private set; } = [];

        public void AddElement(string name, IWebElement element)
        {
            Elements[name] = element;
        }

        public IWebElement GetElement(string name)
        {
            if (Elements.TryGetValue(name, out var element))
            {
                return element;
            }
            throw new KeyNotFoundException($"No element found for key '{name}'");
        }
    }
}
