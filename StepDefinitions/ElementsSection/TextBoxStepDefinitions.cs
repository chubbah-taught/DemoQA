using OpenQA.Selenium;
using DemoQA.Helpers;
using DemoQA.Contexts;
using Reqnroll;

namespace DemoQA.StepDefinitions.ElementsSection
{
    [Binding]
    public class TextBoxStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly ElementsContext _context;

        public TextBoxStepDefinitions(ElementsContext context)
        {
            _driver = WebDriverSetup.GetDriver();
            _context = context;
        }

        [Given("I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            NavigationHelper.OpenHomepage(_driver);

            IWebElement elementsButton = _driver.FindElement(By.XPath("//h5[text()='Elements']"));
            _context.AddElement("elementsButton", elementsButton);
        }

        [When("I click on Elements section")]
        public void WhenIClickOnElementsSection()
        {
            var elementsButton = _context.GetElement("elementsButton");
            NavigationHelper.ScrollToElement(_driver, elementsButton);
            elementsButton.Click();
        }

        [When("I click on Text Box section")]
        public void WhenIClickOnTextBoxSection()
        {
            throw new PendingStepException();
        }

        [When("I enter {string} in Full Name field")]
        public void WhenIEnterInFullNameField(string p0)
        {
            throw new PendingStepException();
        }

        [When("I enter {string} in Email field")]
        public void WhenIEnterInEmailField(string p0)
        {
            throw new PendingStepException();
        }

        [When("I enter {string} in Current Address field")]
        public void WhenIEnterInCurrentAddressField(string p0)
        {
            throw new PendingStepException();
        }

        [When("I enter {string} in Permanent Address field")]
        public void WhenIEnterInPermanentAddressField(string p0)
        {
            throw new PendingStepException();
        }

        [When("I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            throw new PendingStepException();
        }

        [Then("a new section appears")]
        public void ThenANewSectionAppears()
        {
            throw new PendingStepException();
        }

        [Then("I see {string}")]
        public void ThenISee(string p0)
        {
            throw new PendingStepException();
        }
    }
}
