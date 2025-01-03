using DemoQA.Drivers;
using OpenQA.Selenium;
using Reqnroll;
using WebDriverManager;

namespace DemoQA.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly WebDriverSetup _webDriverSetup;

        public Hooks(WebDriverSetup webDriverSetup)
        {
            _webDriverSetup = webDriverSetup;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriverSetup.SetupDriver();
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            WebDriverSetup.QuitDriver();
        }
    }
}