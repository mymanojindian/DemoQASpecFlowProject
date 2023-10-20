using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages
{
    public class HomePage
    {

        private DriverExtensions _driverExtensions;

        #region Locators

        By ElementsLink = By.XPath("//div[@class='card-up']");
        By AlertsFramesWindowLink = By.XPath("(//div[@class='card-up'])[3]");
        By InteractionsLink = By.XPath("(//div[@class='card-up'])[5]");
        By BookStoreApplicationLink = By.XPath("(//div[@class='card-up'])[6]");
        By WidgetLink = By.XPath("(//div[@class='card-up'])[4]");


        #endregion

        #region Constructors 
        public HomePage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion

        public void ClickElementLink (IWebDriver driver)
        {
            _driverExtensions.ClickElement(driver, ElementsLink);

        }
        public void ClickAlertFramesAndWindowsLink(IWebDriver driver)
        {
            _driverExtensions.ClickElement(driver, AlertsFramesWindowLink);

        }

        public void ClickInteractionLink(IWebDriver driver)
        {
            _driverExtensions.ClickElement(driver, InteractionsLink);

        }

        public void ClickBookStoreApplicationLink(IWebDriver driver)
        {
            _driverExtensions.ScrollDownwards(driver);
            _driverExtensions.ClickElement(driver, BookStoreApplicationLink);

        }

        public void ClickWidgetLink(IWebDriver driver)
        {
          

           // string? op = _driverExtensions.DecodePassword(ConfigurationManager.AppSettings["Password"]);
            _driverExtensions.ExplicitWait(driver, WidgetLink, TimeSpan.FromMilliseconds(3000));
            _driverExtensions.ClickElement(driver, WidgetLink);

        }
    }

}
