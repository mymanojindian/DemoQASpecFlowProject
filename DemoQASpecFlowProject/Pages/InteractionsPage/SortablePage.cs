using DemoQASpecFlowProject.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
namespace DemoQASpecFlowProject.Pages.InteractionsPage
{
    public class SortablePage
    {
        private DriverExtensions _driverExtensions;

        #region Locators

        By SortablesLink = By.XPath("//span[contains(text(),'Sortable')]");
        By NumberElementList = By.XPath("//div[@class='list-group-item list-group-item-action']");
        #endregion


        #region Constructors 
        public SortablePage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion
        #region Methods
        public void ClickSortableButton(IWebDriver driver)
        {
            _driverExtensions.ScrollDownwards(driver);
            _driverExtensions.ClickElement(driver, SortablesLink);
        }

        public void ValidateTheSorting(IWebDriver driver)
        {
            IList<IWebElement> numberElements = driver.FindElements(NumberElementList);
            IList<int> numbersList = new List<int>();
            numbersList = numberElements.Take(6).
                Select(e => _driverExtensions.ConvertTextualNumberToInt(e.Text)).ToList();

            List<int> sortedNumbers = new List<int>(numbersList);
            sortedNumbers.Sort((a, b) => b.CompareTo(a));
            
        }



            
        }


        #endregion

    }

