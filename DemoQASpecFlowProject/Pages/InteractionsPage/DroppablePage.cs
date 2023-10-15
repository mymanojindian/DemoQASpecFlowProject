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
    public class DroppablePage
    {
        private DriverExtensions _driverExtensions;

        #region Locators

        By DroppableLink = By.XPath("//span[contains(text(),'Droppable')]");
        By DragMeButton = By.Id("draggable");
        By DropMeButton = By.Id("droppable");
        #endregion


        #region Constructors 
        public DroppablePage(DriverExtensions driverExtensions)
        {
            _driverExtensions = driverExtensions;
        }
        #endregion
        #region Methods
        public void ClickDroppableButton(IWebDriver driver)
        {
            _driverExtensions.ScrollDownwards(driver);
            _driverExtensions.ClickElement(driver, DroppableLink);
        }

        public void DragAndDrop(IWebDriver driver)
        {
            _driverExtensions.ActionsDragAndDrop(driver,DragMeButton, DropMeButton);
        }

            
        }


        #endregion

    }

