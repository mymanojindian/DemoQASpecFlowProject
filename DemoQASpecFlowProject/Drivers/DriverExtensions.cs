using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Drivers
{
    public class DriverExtensions
    {

        public void SendKeys(IWebDriver driver,By locator,string textToBeSent)
        {
            driver.FindElement(locator).SendKeys(textToBeSent);
        }

        public void ClickElement(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
        public IWebElement constructWebelement(IWebDriver driver, By locator)
        {
            return driver.FindElement(locator);

        }

        public void ScrollDownwards(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500);"); 

        }

        public string GetText(IWebDriver driver, By locator)
        {
            return driver.FindElement(locator).Text;

        }

        public void ClearText(IWebDriver driver, By locator)
        {
             driver.FindElement(locator).Clear();

        }
    }
}
