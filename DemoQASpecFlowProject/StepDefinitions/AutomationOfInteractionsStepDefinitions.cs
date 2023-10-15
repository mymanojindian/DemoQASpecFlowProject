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

        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage _homePage;
        private readonly TextBoxPage _textBoxPage;
        private readonly CheckBoxPage _checkBoxPage;
        private readonly WebTablePage _webTablePage;
        private readonly SortablePage _sortablePage;
        private readonly DroppablePage _droppablePage;
        private TextBoxData textBoxData;
        public AutomationOfInteractionsStepDefinitions(ScenarioContext scenarioContext,HomePage homePage,
            TextBoxPage textBoxPage, CheckBoxPage checkBoxPage, WebTablePage webTablePage,
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
            string url = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(url);
        }


        [Given(@"I navigate to the demo QA site Interactions Page")]
        public void GivenINavigateToTheDemoQASiteInteractionsPage()
        {
            _homePage.ClickInteractionLink(driver);
        }

        [When(@"I click the Descending Sort button")]
        public void WhenIClickTheDescendingSortButton()
        {
            _sortablePage.ClickSortableButton(driver);
        }

        [Then(@"the numbers should be sorted in descending order")]
        public void ThenTheNumbersShouldBeSortedInDescendingOrder()
        {
            _sortablePage.ValidateTheSorting(driver);

        }

        [When(@"I click the droppable button")]
        public void WhenIClickTheDroppableButton()
        {
            _droppablePage.ClickDroppableButton(driver);
        }

        [Then(@"the validate user is able to do drag and drop")]
        public void ThenTheValidateUserIsAbleToDoDragAndDrop()
        {
            _droppablePage.DragAndDrop(driver);
            
        }


    }
}