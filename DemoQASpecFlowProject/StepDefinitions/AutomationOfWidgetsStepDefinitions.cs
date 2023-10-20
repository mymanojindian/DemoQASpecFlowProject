using DemoQASpecFlowProject.Data;
using DemoQASpecFlowProject.Drivers;
using DemoQASpecFlowProject.Pages;
using DemoQASpecFlowProject.Pages.ElementsPage;
using DemoQASpecFlowProject.Pages.InteractionsPage;
using DemoQASpecFlowProject.Pages.WidgetsPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow.Assist;

namespace DemoQASpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class AutomationOfWidgetsStepDefinitions
    {

        private IWebDriver? driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage _homePage;
        private readonly AutoCompletePage _autoCompletePage;
        
        public AutomationOfWidgetsStepDefinitions(ScenarioContext scenarioContext,HomePage homePage
            ,AutoCompletePage autoCompletePage)
            
        {
            _scenarioContext = scenarioContext;
            _homePage = homePage;
            _autoCompletePage = autoCompletePage;
        }
       
        [Given(@"Widgets:I open a web browser and Launch Demo QA Site")]
        public void GivenWidgetsIOpenAWebBrowserAndLaunchDemoQASite()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            string? url = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(url);
        }


        [Given(@"I navigate to the demo QA site Widgets Page")]
        public void GivenINavigateToTheDemoQASiteWidgetsPage()
        {
            if (driver != null)
                _homePage.ClickWidgetLink(driver);
            
        }
        [When(@"I click the AutoComplete button")]
        public void WhenIClickTheAutoCompleteButton()
        {
            if (driver != null)
                _autoCompletePage.ClickAutoCompleteButton(driver);
        }

        [Then(@"Validate the autocomplete functionality")]
        public void ThenValidateTheAutocompleteFunctionality()
        {
            if (driver != null)
                _autoCompletePage.ValidateAutoCompleteOption(driver);
        }

        [Given(@"Validate Password Encryption")]
        public void GivenValidatePasswordEncryption()
        {
            
        }




    }
}