using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SkillAssessment_QAEngineer.WebDriver_Helpers
{
    class Waits
    {
        public void waitForElementExists(IWebDriver driver, LocatorType locatorType, string locatorValue, int seconds)
        {
            try
            { 
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                By locator = getElementLocator(locatorType, locatorValue);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            }catch(TimeoutException e)
            {
                Assert.Fail("Element with locatorType : '" + locatorType + "' and locatorValue: '" + locatorValue + "'was not found in current context page.");
            }
        }

        public void WaitToBeClicked(IWebDriver driver, LocatorType locatorType, string locatorValue, int seconds)
        {
            try { 
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                By locator = getElementLocator(locatorType, locatorValue);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            }catch(ElementNotInteractableException e)
            {
                Assert.Fail("Element with locatorType : '" + locatorType + "'wasn't interactable.");
            }
        }

        public By getElementLocator(LocatorType locatorType, string locatorValue)
        {
            By locator = null;

            switch(locatorType)
            {
                case LocatorType.Xpath:
                    locator = By.XPath(locatorValue);
                    break;
                case LocatorType.Id:
                    locator = By.Id(locatorValue);
                    break;
                case LocatorType.Name:
                    locator = By.Name(locatorValue);
                    break;
                case LocatorType.CssSelector:
                    locator = By.CssSelector(locatorValue);
                    break;
            }
            return locator;

        }
        //Function for page scroll
        public void PageScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Drivers.driver;
            js.ExecuteScript("window.scrollBy(0, 650)");
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            //js.ExecuteScript("arguments[0].scrollIntoView()", elementName)
        }

        public void PageScrollUp()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Drivers.driver;
            js.ExecuteScript("window.scrollBy(650, 0)");
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            //js.ExecuteScript("arguments[0].scrollIntoView()", elementName)
        }
    }
}
