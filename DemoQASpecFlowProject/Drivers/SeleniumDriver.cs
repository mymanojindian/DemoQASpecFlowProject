using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQASpecFlowProject.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;


        public SeleniumDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Setup()
        {

            string? browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser)
            {
             case "Chrome":
                {
                ChromeOptions options = new ChromeOptions();
                driver = new ChromeDriver(options);
                _scenarioContext.Set(driver, "SeleniumDriver");
                driver.Manage().Window.Maximize();
                        break;
            }
             case "Firefox":
                    {
                        FirefoxOptions options = new FirefoxOptions();
                        driver = new FirefoxDriver(options);
                        break;
                    }
                case "Edge":
                    {
                        EdgeOptions options = new EdgeOptions();
                        driver = new EdgeDriver(options);
                        break;
                    }
                default:
                    throw new ArgumentException("Unsupported browser type: " + browser);
            }
        
        return driver;
        }
    }
}
