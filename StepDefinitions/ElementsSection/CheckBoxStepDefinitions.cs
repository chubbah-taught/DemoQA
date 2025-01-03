using DemoQA.Contexts;
using DemoQA.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Reqnroll;

[Binding]
public class CheckBoxStepDefinitions
{

    private readonly IWebDriver? _driver;
    private readonly ElementsContext _context;

    public CheckBoxStepDefinitions(ElementsContext context)
    {
        _driver = WebDriverSetup.GetDriver();
        _context = context;
    }

    [When("I click on Check Box")]
    public void WhenIClickOnCheckBox()
    {
        IWebElement checkBoxButton = _driver!.FindElement(By.XPath("//span[text()='Check Box']"));

        checkBoxButton.Click();
    }

    [When("I select {string}")]
    public void WhenISelect(string home)
    {
        throw new PendingStepException();
    }

    [Then("the {string} section appears")]
    public void ThenTheSectionAppears(string p0)
    {
        throw new PendingStepException();
    }

    [Then("the following selections are listed")]
    public void ThenTheFollowingSelectionsAreListed(DataTable dataTable)
    {
        throw new PendingStepException();
    }
}