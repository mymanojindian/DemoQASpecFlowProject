using DemoQASpecFlowProject.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.AlertFramesANdWindowPage
{
    public class AlertsPage
    {

        private DriverExtensions _driverExtensions;
        By AlertsLink = By.XPath("//span[contains(text(),'Alerts')]");
        By PromtButton = By.Id("promtButton"); 
        By PromtResultButton = By.Id("promptResult");
        #region Constructor
        public AlertsPage (DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion

        #region Methods
        public void ClickPromtButton(IWebDriver driver) => _driverExtensions.ClickElement(driver, PromtButton);
        public void ClickAlertsLinkButton(IWebDriver driver)
        {
            _driverExtensions.ScrollDownwards(driver);
            _driverExtensions.ClickElement(driver, AlertsLink);
        }

        public void ValidateAlertPrompt(IWebDriver driver)
        {
            string name = Faker.NameFaker.MaleName();
            _driverExtensions.HandlePromtAlerts(driver, name);
            Assert.AreEqual("You entered " + name, _driverExtensions.GetText(driver, PromtResultButton));

        }


        #endregion



    }
}
