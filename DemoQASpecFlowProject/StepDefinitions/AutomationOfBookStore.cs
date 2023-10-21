using DemoQASpecFlowProject.Data;
using DemoQASpecFlowProject.Drivers;
using DemoQASpecFlowProject.Pages;
using DemoQASpecFlowProject.Pages.BookStorePage;
using DemoQASpecFlowProject.Pages.ElementsPage;
using DemoQASpecFlowProject.Pages.InteractionsPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow.Assist;

namespace DemoQASpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class AutomationOfBookStore
    {

        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage _homePage;
        private readonly BookStorePage _bookStorePage;

        public AutomationOfBookStore(ScenarioContext scenarioContext,HomePage homePage,
            BookStorePage bookStorePage)
        {
            _scenarioContext = scenarioContext;
            _homePage = homePage;
            _bookStorePage = bookStorePage;
            

        }

        [Given(@"BookStore:I open a web browser and Launch Demo QA Site")]
        public void GivenBookStoreIOpenAWebBrowserAndLaunchDemoQASite()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            string? url = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"I navigate to the demo QA site Book store  Page")]
        public void GivenINavigateToTheDemoQASiteBookStorePage()
        {
            if (driver != null)
                _homePage.ClickBookStoreApplicationLink(driver);

        }

        [When(@"I register for new user")]
        public void WhenIRegisterForNewUser()
        {
            if (driver != null)
                _bookStorePage.RegisterForNewUser(driver);
        }

        [When(@"I navigate to Login page")]
        public void WhenINavigateToLoginPage()
        {
            //yet to implement
        }

        [Then(@"Validate user should be able to login successfully")]
        public void ThenValidateUserShouldBeAbleToLoginSuccessfully()
        {
        }


    }
}