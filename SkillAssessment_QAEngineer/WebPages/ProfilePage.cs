using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace SkillAssessment_QAEngineer.WebPages
{
    class ProfilePage
    {
        //Constructor created to initialize the web element objects on this page
        public ProfilePage()
        {
            PageFactory.InitElements(Drivers.driver, this);
        }

        #region Identify Web elements for Profile page

        //Identify Edit profile page button object
        [FindsBy (How = How.CssSelector, Using = "ul#fields>div>a:nth-of-type(1)")]
        [CacheLookup]
        public IWebElement EditProfileBtn { get; set; }

        //Identify Logout button object
        [FindsBy(How = How.CssSelector, Using = "ul#fields>div>a:last-of-type")]
        public IWebElement LogOutBtn { get; set; }

        //Identify Username input field object
        [FindsBy(How = How.XPath, Using = "//ul/li[@id = 'Username']//input[@class = 'textfield singleline']")]
        [FindsBy(How = How.CssSelector, Using = "ul>li#Username>div>input.textfield.singleline")]
        public IWebElement Username { get; set; }

        //Identify Email input field object
        [FindsBy(How = How.CssSelector, Using = "input.textfield.email")]
        public IWebElement Email { get; set; }

        //Identify Mobile input field object
        [FindsBy(How = How.CssSelector, Using = "input.textfield.mobilenumber")]
        public IWebElement Mobile { get; set; }

        //Identify Date Of Birth input field object
        [FindsBy(How = How.CssSelector, Using = "input.textfield.date")]
        public IWebElement DoB { get; set; }

        //Identify New Password input field object
        [FindsBy(How = How.CssSelector, Using = "ul>li#NewPassword>div>input.textfield.singleline")]
        public IWebElement NewPassword { get; set; }

        //Identify Confirm New Password input field object
        [FindsBy(How = How.CssSelector, Using = "ul>li#ConfirmNewPassword>div>input.textfield.singleline")]
        public IWebElement ConfirmNewPassword { get; set; }

        //Identify  Submit Button object
        [FindsBy(How = How.CssSelector, Using = "button.submit-button")]
        public IWebElement Submit { get; set; }
        #endregion

        #region Functions for single input field changes
        public void changeEmailID(string email)
        {
            if(string.IsNullOrEmpty(Email.Text))
            {
                Email.Clear();
            }
            Email.SendKeys(email);            
        }
        public void changeDoB(string dob)
        {
            if (string.IsNullOrEmpty(DoB.Text))
            {
                DoB.Clear();
            }
            DoB.SendKeys(dob);            
        }

        public void changePassword(string newPassword, string confirmPassword)
        {
            NewPassword.SendKeys(newPassword);
            ConfirmNewPassword.SendKeys(confirmPassword);
        }
        #endregion

        #region Function for profile update
        public void ChangeProfileDetails()
        {
            changeEmailID("qaa@test.co.nz");
            changeDoB("20/12/2000");
            changePassword("mother#UbiQuity", "mother#UbiQuity");
            Submit.Click();
            ProfileUpdateSuccessMessage();
        }
        #endregion

        #region Function for validating Profile update success message
        public void ProfileUpdateSuccessMessage()
        {
            var ActualMsg = Drivers.driver.FindElement(By.CssSelector("p#SuccessMessage")).Text;
            Console.WriteLine("Message captured as : " + ActualMsg);
            var ExpectedMsg = "Update is successful! Please see updated information below";
            Assert.That(ActualMsg, Is.EqualTo(ExpectedMsg));
        }
        #endregion
    }
}
