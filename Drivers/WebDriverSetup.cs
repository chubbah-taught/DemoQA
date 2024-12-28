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
    private const string Browser = "firefox";
    
    private static IWebDriver? _driver;
    
    public static IWebDriver GetDriver()
    {
        switch (Browser.ToLower())
        {
            case "chrome":
                new DriverManager().SetUpDriver(new ChromeConfig());
                var chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                _driver = new ChromeDriver(chromeOptions);
                break;

            case "firefox":
                new DriverManager().SetUpDriver(new FirefoxConfig());
                var fireFoxOptions = new FirefoxOptions();
                fireFoxOptions.AddArgument("--start-maximized");
                _driver = new FirefoxDriver(fireFoxOptions);
                break;

            case "edge":
                new DriverManager().SetUpDriver(new EdgeConfig());
                var edgeOptions = new EdgeOptions();
                edgeOptions.AddArgument("start-maximized");
                _driver = new EdgeDriver(edgeOptions);
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