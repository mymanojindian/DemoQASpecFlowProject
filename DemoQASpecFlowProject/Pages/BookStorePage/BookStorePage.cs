using DemoQASpecFlowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Pages.BookStorePage
{
    public class BookStorePage
    {

        private DriverExtensions _driverExtensions;
        By NewUserButton = By.Id("newUser");
        By LoginButton = By.Id("login");
        By FirstName = By.Id("firstname");
        By lastName = By.Id("lastname");
        By UserName = By.Id("userName"); 
        By Password = By.Id("password"); 
        By RegisterButton = By.Id("register"); 
        By BackToLogin = By.Id("gotologin");
        By RobotRadioButton = By.XPath("//span[@class='recaptcha-checkbox goog-inline-block recaptcha-checkbox-unchecked rc-anchor-checkbox']");
        string userName;
        string password;
        #region Constructors 
        public BookStorePage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }

        public void RegisterForNewUser(IWebDriver driver)
        {
            _driverExtensions.ExplicitWait(driver, LoginButton, TimeSpan.FromMilliseconds(3000));
            _driverExtensions.ClickElement(driver, LoginButton);
            _driverExtensions.ClickElement(driver, NewUserButton);
            _driverExtensions.SendKeys(driver,FirstName, Faker.NameFaker.FirstName());
            _driverExtensions.SendKeys(driver, lastName, Faker.NameFaker.LastName());
            userName = Faker.NameFaker.FirstName()+ Faker.NameFaker.LastName();
            password = Faker.NameFaker.FirstName() + "@" + Faker.NameFaker.LastName() + Faker.NumberFaker.Number(999,99999);
            _driverExtensions.SendKeys(driver, UserName, userName);
            _driverExtensions.SendKeys(driver, Password, password);
            _driverExtensions.ScrollDownwards(driver);
            _driverExtensions.ExplicitWait(driver, RobotRadioButton, TimeSpan.FromMilliseconds(3000));
            _driverExtensions.ClickElement(driver, RobotRadioButton);
            _driverExtensions.ClickElement(driver, RegisterButton);


        }
        #endregion
    }
}
