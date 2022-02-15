using NUnit.Framework;
using SkillAssessment_QAEngineer.WebPages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SkillAssessment_QAEngineer.StepDefinition
{
    [Binding]
    public class ProfileUpdateSteps
    {
        LoginPage loginpage = new LoginPage();
        ProfilePage profile = new ProfilePage();


        [Given(@"the user is logged in with valid '(.*)' and '(.*)' successfully")]
        public void GivenTheUserIsLoggedInWithValidAndSuccessfully(string useRname, string pasSword)
        {
            loginpage.EnterUserNamePassword(useRname, pasSword);
            loginpage.LoginBtn.Click();
        }

        [When(@"the user clicks on edit profile button")]
        public void WhenTheUserClicksOnEditProfileButton()
        {
            profile.EditProfileBtn.Click();
            
        }

        [Then(@"the edit profile page is shown")]
        public void ThenTheEditProfilePageIsShown()
        {
            var expectedTitle = "Ubiquity Engage";
            var actualTitle = Drivers.driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }

        [When(@"the user edits '(.*)', '(.*)', '(.*)' and '(.*)")]
        public void WhenTheUserEditsAndConfirmPassword(string emailAddress, string DateOfBirth, string newPassword, string confirmPassword)
        {
            profile.changeEmailID(emailAddress);
            profile.changeDoB(DateOfBirth);
            profile.changePassword(newPassword, confirmPassword);
        }

        [When(@"clicks on submit button")]
        public void WhenClicksOnSubmitButton()
        {
            profile.Submit.Click();
        }

       
        [Then(@"the updated details are shown along with the '(.*)")]
        public void ThenTheUpdatedDetailsAreShownAlongWithThe(string successmessage)
        {
            profile.ProfileUpdateSuccessMessage();
        }
    }
}
