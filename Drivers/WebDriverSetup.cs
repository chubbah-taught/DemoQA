using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoQA.Drivers;

public static class WebDriverSetup
{
    // Define browser type
    private const string Browser = "chrome";
    
    private static IWebDriver? _driver;
    
    public static IWebDriver GetDriver()
    {
        switch (Browser.ToLower())
        {
            case "chrome":
                new DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver();
                break;

            case "firefox":
                new DriverManager().SetUpDriver(new FirefoxConfig());
                _driver = new FirefoxDriver();
                break;

            case "edge":
                new DriverManager().SetUpDriver(new EdgeConfig());
                _driver = new EdgeDriver();
                break;

            default:
                throw new ArgumentException($"Browser '{Browser}' is not supported. Please use 'chrome', 'firefox', or 'edge'");
        }

        return _driver;
    }

    public static void QuitDriver()
    {
        _driver?.Quit();
        _driver = null;
    }
}