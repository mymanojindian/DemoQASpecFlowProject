using DemoQASpecFlowProject.Data;
using DemoQASpecFlowProject.Drivers;
using DemoQASpecFlowProject.Pages;
using DemoQASpecFlowProject.Pages.ElementsPage;
using DemoQASpecFlowProject.Pages.InteractionsPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow.Assist;

namespace DemoQASpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class AutomationOfInteractionsStepDefinitions
    {

        private IWebDriver? driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage _homePage;
        private readonly SortablePage _sortablePage;
        private readonly DroppablePage _droppablePage;
        
        public AutomationOfInteractionsStepDefinitions(ScenarioContext scenarioContext,HomePage homePage,
            SortablePage sortablePage, DroppablePage droppablePage)
        {
            _scenarioContext = scenarioContext;
            _homePage = homePage;
            _sortablePage = sortablePage;
            _droppablePage = droppablePage;
            
        }

        [Given(@"Interactions:I open a web browser and Launch Demo QA Site")]
        public void GivenInteractionsIOpenAWebBrowserAndLaunchDemoQASite()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            string? url = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(url);
        }


        [Given(@"I navigate to the demo QA site Interactions Page")]
        public void GivenINavigateToTheDemoQASiteInteractionsPage()
        {
            if (driver != null)
            {
                _homePage.ClickInteractionLink(driver);
            }
        }

        [When(@"I click the Descending Sort button")]
        public void WhenIClickTheDescendingSortButton()
        {
            if (driver != null)
                _sortablePage.ClickSortableButton(driver);
        }

        [Then(@"the numbers should be sorted in descending order")]
        public void ThenTheNumbersShouldBeSortedInDescendingOrder()
        {
            if (driver != null)
                _sortablePage.ValidateTheSorting(driver);

        }

        [When(@"I click the droppable button")]
        public void WhenIClickTheDroppableButton()
        {
            if (driver != null)
                _droppablePage.ClickDroppableButton(driver);
        }

        [Then(@"the validate user is able to do drag and drop")]
        public void ThenTheValidateUserIsAbleToDoDragAndDrop()
        {
            if (driver != null)
                _droppablePage.DragAndDrop(driver);
            
        }


    }
}