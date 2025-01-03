using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoQA.Drivers;

public  class WebDriverSetup
{
    // Define browser type
    private const string Browser = "chrome";
    
    private static IWebDriver? _driver;
    
    public static void SetupDriver()
    {
        if (_driver == null)
        {
            switch (Browser.ToLower())
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeOptions = new ChromeOptions();
                    //chromeOptions.AddArgument("--start-maximized");
                    _driver = new ChromeDriver(chromeOptions);
                    break;

                case "firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    var fireFoxOptions = new FirefoxOptions();
                    //fireFoxOptions.AddArgument("--start-maximized");
                    _driver = new FirefoxDriver(fireFoxOptions);
                    break;

                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    var edgeOptions = new EdgeOptions();
                    //edgeOptions.AddArgument("start-maximized");
                    _driver = new EdgeDriver(edgeOptions);
                    break;

                default:
                    throw new ArgumentException($"Browser '{Browser}' is not supported. Please use 'chrome', 'firefox', or 'edge'");
            }
        }
    }

    public static IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            throw new InvalidOperationException("WebDriver has not been initialized.");
        }

        return _driver;
    }

    public static void QuitDriver()
    {
        _driver?.Quit();
        _driver = null;
    }
}