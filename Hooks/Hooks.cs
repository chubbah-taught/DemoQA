using DemoQA.Drivers;
using Reqnroll;

namespace DemoQA.Hooks
{
    [Binding]
    public class Hooks
    {
        [AfterScenario]
        public static void AfterTestRun()
        {
            WebDriverSetup.QuitDriver();
        }
    }
}