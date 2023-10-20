using DemoQASpecFlowProject.Data;
using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.ElementsPage
{
    public class TextBoxPage
    {
        #region
        By TextBoxLink = By.XPath("//span[contains(text(),'Text Box')]");
        
        By FullNameTextBox = By.Id("userName");
        By UserEmailTextBox = By.Id("userEmail");
        By CurrentAddressTextBox = By.Id("currentAddress");
        By PermanentAddressTextBox = By.Id("permanentAddress");
        By SubmitButton = By.XPath("//button[@id='submit']");
        By FullNameLabel = By.Id("name");
        By UserEmailLabel = By.Id("email");
        By CurrentAddressLabel = By.Id("currentAddress");
        By PermanentAddressLabel = By.Id("permanentAddress");

        #endregion
        private DriverExtensions _driverExtensions;

        #region Constructors 
        public TextBoxPage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion

        #region methods

        public void NavigateToTextBox(IWebDriver driver) => _driverExtensions.ClickElement(driver, TextBoxLink);


        public void UpdateAllTextBoxes(IWebDriver driver,TextBoxData textBoxData)
        {
            if (textBoxData.FullName != null)
                _driverExtensions.SendKeys(driver, FullNameTextBox, textBoxData.FullName);
            if(textBoxData.Email!= null)
                _driverExtensions.SendKeys(driver, UserEmailTextBox, textBoxData.Email);
            if(textBoxData.CurrentAddress!=null)    
            _driverExtensions.SendKeys(driver, CurrentAddressTextBox, textBoxData.CurrentAddress);
            if(textBoxData.PermanentAddress!=null)    
            _driverExtensions.SendKeys(driver, PermanentAddressTextBox, textBoxData.PermanentAddress);
                _driverExtensions.ScrollDownwards(driver);
            
        }

        public void ClickSubmitButton(IWebDriver driver) => _driverExtensions.ClickElement(driver,SubmitButton);
        public string GetFullNameUnResult(IWebDriver driver)
        {
            return _driverExtensions.GetText(driver, FullNameLabel); ;
        }

        

        #endregion

    }
}
