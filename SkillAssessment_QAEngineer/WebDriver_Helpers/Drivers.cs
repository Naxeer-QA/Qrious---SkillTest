using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SkillAssessment_QAEngineer
{
    public class Drivers
    {
        public static IWebDriver driver;

        // Function to start the browser before the test case execution
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            NavigateBaseUrl();
        }

        //Function to wait implicitly(a specific amount of time before act)
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }

        public static void NavigateBaseUrl()
        {
            driver.Navigate().GoToUrl("http://13.75.189.136:8081/");
        }

        //Function to quit the browser after every test execution
        [TearDown]
        public void TerminateBrowser()
        {
            TurnOnWait();
            driver.Close();
        }
    }
}
