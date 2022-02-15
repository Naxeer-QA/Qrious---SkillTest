using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace SkillAssessment_QAEngineer.WebPages
{
    class LoginPage
    {
        #region Identify Web elements for login page

        //Identity username input field
        [FindsBy(How = How.CssSelector, Using = "input#username")]
        [CacheLookup]
        public IWebElement UserName { get; set; }
        
        //Identify password input field
        [FindsBy(How = How.CssSelector, Using = "input#password")]
        [CacheLookup]
        public IWebElement PassWord { get; set; }

        //Identify Login button
        [FindsBy(How = How.CssSelector, Using = "button.btn")]
        [CacheLookup]
        public IWebElement LoginBtn { get; set; }

        //Identify Logout button object
        [FindsBy(How = How.CssSelector, Using = "ul#fields>div>a:last-of-type")]
        public IWebElement LogOutBtn { get; set; }
        #endregion

        //Constructor created to initialize the web element objects on this page
        public LoginPage()
        {
            PageFactory.InitElements(Drivers.driver, this);
        }

        #region Function for username & password inputs
        public void EnterUserNamePassword(string username, string password)
        {
            UserName.SendKeys(username);
            PassWord.SendKeys(password);
        }
        #endregion

        #region login success
        public void LoginSuccess()
        {
            EnterUserNamePassword("ubiquity", "P@ss123#UbiQuity");
            LoginBtn.Click();
        }
        #endregion

        #region Logout success
        public void LogOutSuccess()
        {
            //Below is relative XPath for Logout Button
            //IWebElement Logout = driver.FindElement(By.XPath("//ul/div[@class ='form-button right']/a/span[text()='Logout']"));

            //Below is a cssSelector for Logout Button
            IWebElement Logout = Drivers.driver.FindElement(By.CssSelector("ul#fields>div>a:last-of-type"));
            WebDriverWait wait = new WebDriverWait(Drivers.driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Logout)).Click();
        }
        #endregion

    }
}
