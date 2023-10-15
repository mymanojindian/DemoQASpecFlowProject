using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.AlertFramesANdWindowPage
{
    public class BrowserWindowsPage
    {

        private DriverExtensions _driverExtensions;
        string currentWindow;
        By BrowserWindowsLink = By.XPath("//span[contains(text(),'Browser Windows')]"); 
        By MessageWindowLink = By.Id("messageWindowButton");
        By MessageBody = By.XPath("//body");
        #region
        public BrowserWindowsPage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }

        public void ClickBrowserWindowsButton(IWebDriver driver) => _driverExtensions.ClickElement(driver, BrowserWindowsLink);
        public void ClickMessageWindowsButton(IWebDriver driver)
        {
             currentWindow = driver.CurrentWindowHandle;
            _driverExtensions.ClickElement(driver, MessageWindowLink);
        }

        public bool HandleMultipleWindows(IWebDriver driver)
        {
         
            var mutipleWindows = driver.WindowHandles;
            foreach(var win in mutipleWindows)
            {
                if(win!=currentWindow)
                {
                    string output = _driverExtensions.GetText(driver, MessageBody);
                    if (output.Contains("Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.")) ;
                    return true;
                }
            }
            return false;
        }
        #endregion


    }
}
