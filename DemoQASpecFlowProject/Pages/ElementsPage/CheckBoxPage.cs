using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.ElementsPage
{
    public class CheckBoxPage
    {
        private DriverExtensions _driverExtensions;

        #region Locators
        By CheckBoxLink = By.XPath("//span[contains(text(),'Check Box')]");
        By HomeExtensionLink = By.XPath("//button[@class='rct-collapse rct-collapse-btn']");
        By DeskTopExtensionLink = By.XPath("(//button[@class='rct-collapse rct-collapse-btn'])[2]");
        By NotesCheckBox = By.XPath("(//span[@class='rct-checkbox'])[3]");
        By ResultLabel = By.XPath("//span[@class='text-success']");
        #endregion
        #region Constructors 
        public CheckBoxPage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion

        #region Methods
        public void ClickCheckBoxButton(IWebDriver driver) => _driverExtensions.ClickElement(driver, CheckBoxLink);
        public void ClickHomeExtensionLink(IWebDriver driver) => _driverExtensions.ClickElement(driver, HomeExtensionLink);

        public void ClickNoteLink(IWebDriver driver) => _driverExtensions.ClickElement(driver, NotesCheckBox);

        public void ClickDeskTopExtensionLink(IWebDriver driver) => _driverExtensions.ClickElement(driver, DeskTopExtensionLink);

        public string GetResultText(IWebDriver driver) => _driverExtensions.GetText(driver, ResultLabel);

        #endregion

    }
}
