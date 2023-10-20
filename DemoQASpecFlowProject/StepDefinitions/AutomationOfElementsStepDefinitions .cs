using DemoQASpecFlowProject.Data;
using DemoQASpecFlowProject.Drivers;
using DemoQASpecFlowProject.Pages;
using DemoQASpecFlowProject.Pages.ElementsPage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow.Assist;

namespace DemoQASpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class AutomationOfElementsStepDefinitions
    {

        private IWebDriver? driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage _homePage;
        private readonly TextBoxPage _textBoxPage;
        private readonly CheckBoxPage _checkBoxPage;
        private readonly WebTablePage _webTablePage;
        private TextBoxData? textBoxData;
        public AutomationOfElementsStepDefinitions(ScenarioContext scenarioContext,HomePage homePage,
            TextBoxPage textBoxPage, CheckBoxPage checkBoxPage, WebTablePage webTablePage)
        {
            _scenarioContext = scenarioContext;
            _homePage = homePage;
            _textBoxPage = textBoxPage;
            _checkBoxPage = checkBoxPage;
            _webTablePage = webTablePage;
            
        }

        [Given(@"I open a web browser and Launch Demo QA Site")]
        public void GivenIOpenAWebBrowserAndLaunchDemoQASite()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            string? url = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"I navigate to the demo QA site Element Page")]
        public void GivenINavigateToTheDemoQASiteElementPage()
        {
            if (driver != null)
                _homePage.ClickElementLink(driver);

        }
      
        [When(@"I enter the following in the text box")]
        public void WhenIEnterTheFollowingInTheTextBox(Table table)
        {
            textBoxData = table.CreateInstance<TextBoxData>();
            if (driver != null)
            {
                _textBoxPage.NavigateToTextBox(driver);
                _textBoxPage.UpdateAllTextBoxes(driver, textBoxData);
            }
        }


        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            if (driver != null)
                _textBoxPage.ClickSubmitButton(driver);
        }

        
        [Then(@"the submitted text should be same as entered")]
        public void ThenTheSubmittedTextShouldBeSameAsEntered()
        {
            if (textBoxData != null)
            {
                string ExpectedResult = "Name:" + textBoxData.FullName;
                if (driver != null)
                    Assert.AreEqual("Name:" + textBoxData.FullName, _textBoxPage.GetFullNameUnResult(driver));
            }
        }

        [When(@"I select Notes under Desktop section")]
        public void WhenISelectNotesUnderDesktopSection()
        {


        }

        [When(@"Select the desktop menu")]
        public void WhenSelectTheDesktopMenu()
        {
            if (driver != null)
            {
                _checkBoxPage.ClickCheckBoxButton(driver);
                _checkBoxPage.ClickHomeExtensionLink(driver);
                _checkBoxPage.ClickDeskTopExtensionLink(driver);
                _checkBoxPage.ClickNoteLink(driver);
            }
        }


        [Then(@"Validate selected elements are displayed below")]
        public void ThenValidateSelectedElementsAreDisplayedBelow()
        {
            if (driver != null)
                Assert.AreEqual( "notes",_checkBoxPage.GetResultText(driver));
            
        }
        [When(@"I select WebtableLink")]
        public void WhenISelectWebtableLink()
        {
            if (driver != null)
                _webTablePage.ClickWebTableButton(driver);
        }

        [When(@"I Edit the WebTable")]
        public void WhenIEditTheWebTable()
        {
            if (driver != null)
                _webTablePage.EditWebTable(driver);
        }

        [Then(@"Validate the Changes")]
        public void ThenValidateTheChanges()
        {
            //The Changes has to be implemented 
        }



    }
}