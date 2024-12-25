using DemoQA.Drivers;
using Reqnroll;

namespace DemoQA.Hooks
{
    [Binding]
    public class Hooks
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            WebDriverSetup.QuitDriver();
        }
    }
}