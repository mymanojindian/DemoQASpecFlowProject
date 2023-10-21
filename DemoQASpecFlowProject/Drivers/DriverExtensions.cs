using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Drivers
{
    public class DriverExtensions
    {
        public string EnCodePassword(string Password)
        {
            string encodedString = Convert.ToBase64String(Encoding.UTF8.GetBytes(Password));
            return encodedString;
        }
        public string DecodePassword(string encodedPassword)
        {
            var utf8Decoder = new UTF8Encoding().GetDecoder();
            byte[] enCodedBytes = Convert.FromBase64String(encodedPassword);
            int charCount = utf8Decoder.GetCharCount(enCodedBytes,0,enCodedBytes.Length);
            char[] decoded_char = new char[charCount];
            utf8Decoder.GetChars(enCodedBytes,0, enCodedBytes.Length, decoded_char, 0);
            return new(decoded_char);
        }
        public void ExplicitWait(IWebDriver driver, By locator,TimeSpan timeSpan)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeSpan);
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
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
        public void HandlePromtAlerts(IWebDriver driver,string message)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys(message);
            alert.Accept();
        }
        public void AcceptAlerts(IWebDriver driver)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }


        public void ScrollDownwards(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 500);"); 

        }

        public void JSSendText(IWebDriver driver,By locator,string textToSend)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = arguments[1];", constructWebelement(driver,locator), textToSend);

        }
        public string GetText(IWebDriver driver, By locator)
        {
            return driver.FindElement(locator).Text;

        }

        public void ClearText(IWebDriver driver, By locator)
        {
             driver.FindElement(locator).Clear();

        }

        public void ActionsDragAndDrop(IWebDriver driver , By sourceElement, By destinationElement)
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(constructWebelement(driver, sourceElement), constructWebelement(driver, destinationElement));

        }
        public   int ConvertTextualNumberToInt(string text)
        {
            switch (text.ToLower())
            {
                case "one":
                    return 1;
                case "two":
                    return 2;

                case "three":
                    return 3;
                case "four":
                    return 4;

                case "five":
                    return 5;
                case "six":
                    return 6;
                default:
                    throw new ArgumentException("Invalid input");
            }
        }
    }
}
