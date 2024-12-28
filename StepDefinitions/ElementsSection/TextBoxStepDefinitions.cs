using OpenQA.Selenium;
using DemoQA.Helpers;
using DemoQA.Contexts;
using DemoQA.Drivers;
using Reqnroll;
using FluentAssertions;

namespace DemoQA.StepDefinitions.ElementsSection;

[Binding]
public class TextBoxStepDefinitions
{
    private readonly IWebDriver? _driver;
    private readonly ElementsContext _context;

    private TextBoxStepDefinitions(ElementsContext context)
    {
        _driver = WebDriverSetup.GetDriver();
        _context = context;
    }

    [Given("I am on the homepage")]
    private void GivenIAmOnTheHomepage()
    {
        NavigationHelper.OpenHomepage(_driver);
    }

    [When("I click on Elements section")]
    private void WhenIClickOnElementsSection()
    {
        var elementsButton = _driver!.FindElement(By.XPath("//h5[text()='Elements']"));
        
        NavigationHelper.ScrollToElement(_driver!, elementsButton);
        
        elementsButton.Click();
    }
    
    [When("I click on Text Box section")]
    private void WhenIClickOnTextBoxSection()
    {
        var textBoxButton = _driver!.FindElement(By.XPath("//span[text()='Text Box']"));
        
        textBoxButton.Click();
    }
        
    [When("""I enter "(.*)" in Full Name field""")]
    private void WhenIEnterInFullNameField(string userName)
    {
        var fullNameField = _driver!.FindElement(By.Id("userName"));
        fullNameField.SendKeys(userName);
    }
    
    [When("""I enter "(.*)" in Email field""")]
    private void WhenIEnterInEmailField(string userEmail)
    {
        var emailField = _driver!.FindElement(By.Id("userEmail"));
        emailField.SendKeys(userEmail);
    }
    
    [When("""I enter "(.*)" in Current Address field""")]
    private void WhenIEnterInCurrentAddressField(string userCurrentAddress)
    {
        var currentAddressField = _driver!.FindElement(By.Id("currentAddress"));
        currentAddressField.SendKeys(userCurrentAddress);
    }
    
    [When("""I enter "(.*)" in Permanent Address field""")]
    private void WhenIEnterInPermanentAddressField(string userPermanentAddress)
    {
        var permanentAddressField = _driver!.FindElement(By.Id("permanentAddress"));
        permanentAddressField.SendKeys(userPermanentAddress);
    }
    
    [When("I click on Submit button")]
    private void WhenIClickOnSubmitButton()
    {
        var submitButton = _driver!.FindElement(By.Id("submit"));
        NavigationHelper.ScrollToElement(_driver, submitButton);
        submitButton.Click();
    }
    
    [Then("output section appears")]
    private void OutputSectionAppears()
    {
        var outputSection = _driver!.FindElement(By.Id("output"));
        outputSection.Should().NotBeNull("Output section should appear on the screen");
        
        _context.AddLocator("outPutSection", By.Id("output"));
    }
    
    [Then("""I see "(.*)" in name field""")]
    public void ThenISeeInNameField(string expectedUserName)
    {
        var nameField = _driver!.FindElement(
            _context.GetLocator("outPutSection")
            ).FindElement(By.Id("name")
        );
        
        nameField.Text.Should().Contain(expectedUserName);
    }
    
    [Then("""I see "(.*)" in email field""")]
    public void ThenISeeInEmailField(string expectedUserEmail)
    {
        var emailField = _driver!.FindElement(
            _context.GetLocator("outPutSection")
            ).FindElement(By.Id("email")
        );
        
        emailField.Text.Should().Contain(expectedUserEmail);
    }
    
    [Then("""I see "(.*)" in current address field""")]
    public void ThenISeeInCurrentAddressField(string expectedUserCurrentAddress)
    {
        var currentAddressField = _driver!.FindElement(
            _context.GetLocator("outPutSection")
            ).FindElement(By.Id("currentAddress")
        );
        
        currentAddressField.Text.Should().Contain(expectedUserCurrentAddress);
    }
    
    [Then("""I see "(.*)" in permanent address field""")]
    public void ThenISeeInPermanentAddressField(string expectedUserPermanentAddress)
    {
        var permanentAddressField = _driver!.FindElement(
            _context.GetLocator("outPutSection")
            ).FindElement(By.Id("permanentAddress")
        );
        
        permanentAddressField.Text.Should().Contain(expectedUserPermanentAddress);
    }
    
    [Then(@"email field state is changed to error state")]
    public void ThenEmailFieldStateIsChangedToErrorState()
    {
        try
        {
            _driver!.FindElement(By.XPath("//input[@class='mr-sm-2 field-error form-control']"));
        }
        catch (NoSuchElementException)
        {
            throw new AssertionException("Email field error state should be present when invalid email entered.");
        }
    }
    
    [Then(@"output section is empty")]
    public void ThenOutputSectionIsEmpty()
    {
        var outPutSection = _driver!.FindElement(By.Id("output"));
        var nameField = outPutSection.FindElements(By.Id("name"));
        var emailField = outPutSection.FindElements(By.Id("email"));
        var currentAddressField = outPutSection.FindElements(By.Id("currentAddress"));
        var permanentAddressField = outPutSection.FindElements(By.Id("permanentAddress"));
    
        nameField.Count.Should().BeLessThan(1);
        emailField.Count.Should().BeLessThan(1);
        currentAddressField.Count.Should().BeLessThan(1);
        permanentAddressField.Count.Should().BeLessThan(1);
    }
}