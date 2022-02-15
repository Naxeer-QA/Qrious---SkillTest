using NUnit.Framework;
using SkillAssessment_QAEngineer.WebDriver_Helpers;
using SkillAssessment_QAEngineer.WebPages;
using System.Threading;

namespace SkillAssessment_QAEngineer
{
    public class Tests : Drivers

    {
        [Test]
        public void SuccessfulLogin()
        {
            Initialize();
            LoginPage loginpage = new LoginPage();
            loginpage.LoginSuccess();
            Thread.Sleep(9000);
            loginpage.LogOutSuccess();
        }

        [Test]
        public void UpdateProfile()
        {
            Initialize();
            LoginPage loginpage = new LoginPage();
            loginpage.LoginSuccess();
            Thread.Sleep(9000);
            ProfilePage profile = new ProfilePage();
            profile.EditProfileBtn.Click();
            Waits wait = new Waits();
            wait.PageScrollDown();
            profile.ChangeProfileDetails();
        }
    }
}