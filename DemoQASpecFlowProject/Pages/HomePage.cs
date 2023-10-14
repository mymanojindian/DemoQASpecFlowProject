using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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

      
    }
}
