using DemoQASpecFlowProject.Data;
using DemoQASpecFlowProject.Drivers;
using DemoQASpecFlowProject.Pages;
using DemoQASpecFlowProject.Pages.AlertFramesANdWindowPage;
using DemoQASpecFlowProject.Pages.ElementsPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow.Assist;

namespace DemoQASpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class AlertsFramesAndWindowsStepDefinitions
    {

        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage _homePage;
        private readonly BrowserWindowsPage _browserWindowsPage;
        private readonly AlertsPage _alertsPage;
        public AlertsFramesAndWindowsStepDefinitions(ScenarioContext scenarioContext,HomePage homePage,
            BrowserWindowsPage browserWindowsPage,AlertsPage alertsPage)
           
        {
            _scenarioContext = scenarioContext;
            _homePage = homePage;
            _browserWindowsPage = browserWindowsPage;
            _alertsPage = alertsPage;
            
          
        }
        [Given(@"Windows : I open a web browser and Launch Demo QA Site")]
        public void GivenWindowsIOpenAWebBrowserAndLaunchDemoQASite()
        {

            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            string? url = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(url);
        }



        [Given(@"I navigate to the demo QA site FramesWindowAlert Page")]
        public void GivenINavigateToTheDemoQASiteFramesWindowAlertPage()
        {
                _homePage.ClickAlertFramesAndWindowsLink(driver);
        }

        [When(@"I navigate to browser windows page")]
        public void WhenINavigateToBrowserWindowsPage()
        {
            _browserWindowsPage.ClickBrowserWindowsButton(driver);
        }

        [When(@"Select new Window")]
        public void WhenSelectNewWindow()
        {
            
            
                _browserWindowsPage.ClickBrowserWindowsButton(driver);
                _browserWindowsPage.ClickMessageWindowsButton(driver);
            
        
        }

        [Then(@"Validate user is able to handle Multiple window")]
        public void ThenValidateUserIsAbleToHandleMultipleWindow()
        {
                Assert.AreEqual(true, _browserWindowsPage.HandleMultipleWindows(driver));

        }

        [When(@"I navigate to Alerts page")]
        public void WhenINavigateToAlertsPage()
        {
                _alertsPage.ClickAlertsLinkButton(driver);
        }

        [When(@"Select new Alerts")]
        public void WhenSelectNewAlerts()
        {
                _alertsPage.ClickPromtButton(driver);
        }

        [Then(@"Validate user is able to handle Alerts")]
        public void ThenValidateUserIsAbleToHandleAlerts()
        {
                _alertsPage.ValidateAlertPrompt(driver);
        }

    }
}