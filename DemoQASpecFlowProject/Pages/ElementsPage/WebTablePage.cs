using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.ElementsPage
{
    public class WebTablePage
    {
        private DriverExtensions _driverExtensions;
        #region Locators
        By CheckBoxLink = By.XPath("//span[contains(text(),'Web Tables')]");
        By EditFirstRecordButton = By.Id("edit-record-1");
        By FirstNameTextBox = By.Id("firstName");
        By LastNameTextBox = By.Id("lastName");
        By UserEmailTextBox = By.Id("userEmail");
        By SubmitButton = By.Id("submit");

        #endregion

        #region Constructors 
        public WebTablePage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion

        public void ClickWebTableButton(IWebDriver driver) => _driverExtensions.ClickElement(driver, CheckBoxLink);

        public void EditWebTable(IWebDriver driver)
        {
            _driverExtensions.ClickElement(driver,EditFirstRecordButton);
            _driverExtensions.ClearText(driver,FirstNameTextBox);
            _driverExtensions.SendKeys(driver, FirstNameTextBox, Faker.NameFaker.FirstName());
            _driverExtensions.ClearText(driver,LastNameTextBox);
            _driverExtensions.SendKeys(driver, LastNameTextBox, Faker.NameFaker.LastName());
            _driverExtensions.ClearText(driver,UserEmailTextBox);
            _driverExtensions.SendKeys(driver, UserEmailTextBox, Faker.InternetFaker.Email());
            _driverExtensions.ClickElement(driver, SubmitButton);
        }

    }
}
