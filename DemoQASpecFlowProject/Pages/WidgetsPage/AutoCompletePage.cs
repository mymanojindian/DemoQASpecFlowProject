using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.WidgetsPage
{
    public class AutoCompletePage
    {
        private DriverExtensions _driverExtensions;

        #region Locators

        By AutoCompleteLink = By.XPath("//span[contains(text(),'Auto Complete')]");
        By MultipleColorTextBox = By.Id("autoCompleteMultipleContainer");
        By AutoCompleteOptions = By.XPath("//div[@id='autoCompleteMultipleContainer']/div[@class='auto-complete__value']");
        By FirstSuggetions = By.XPath("//div[@id='autoCompleteMultipleContainer']/div[@class='auto-complete__menu']/div[1]");
        #endregion

        #region Constructors 
        public AutoCompletePage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion

        #region Methods
        public void ClickAutoCompleteButton(IWebDriver driver)
        {
            _driverExtensions.ScrollDownwards(driver);
            _driverExtensions.ClickElement(driver, AutoCompleteLink);
        }

        public void ValidateAutoCompleteOption(IWebDriver driver)
        {
        _driverExtensions.ExplicitWait(driver,MultipleColorTextBox,TimeSpan.FromSeconds(5));
            _driverExtensions.ClickElement(driver, MultipleColorTextBox);
            _driverExtensions.JSSendText(driver, MultipleColorTextBox, "b");
            _driverExtensions.ExplicitWait(driver,AutoCompleteOptions,TimeSpan.FromSeconds(5));
            _driverExtensions.ExplicitWait(driver, FirstSuggetions, TimeSpan.FromSeconds(5));
            _driverExtensions.ClickElement(driver, FirstSuggetions);
        }
        #endregion

    }
}
