# Qrious---SkillTest

Whilst developing this test project, I employed the following;
Visual Studio - IDE
C# 
NUnit
Specflow
and other relevant packages to implement the Page Object Model using Page factory class.
I've created two unit tests just to make sure that the program is working okay and automated the requested scenario in a Gherkin language using Specflow. Generated step definitions and mapped them with the relevant functions.

Below is an automation scenario just to review, you may run it using an IDE. It will be through successfully:

**Scenario: User updates profile**
	Given the user is logged in with valid '<useRname>' and '<pasSword>' successfully
	When the user clicks on edit profile button
	Then the edit profile page is shown
	When the user edits '<emailAddress>', '<DateOfBirth>', '<newPassword>' and '<confirmPassword>
	And clicks on submit button
	Then the updated details are shown along with the '<successmessage>
	Examples: 
	| useRname | pasSword         |emailAddress          | DateOfBirth | newPassword     | confirmPassword |successmessage                                             |
	| ubiquity | P@ss123#UbiQuity |khannazeer8@gmail.com | 08/09/2000  | mother#UbiQuity | mother#UbiQuity |Update is successful! Please see updated information below |

As requested, I've identified two issues whilst performing manaul test of the user story. To replicate the same, I've created a bug report and evidenced the same with the screenshots.

 As requested, you may have a look at my other projects on github using the following URLs.
  https://github.com/Naxeer-QA/Sprint--3---Advanced.git
  https://github.com/Naxeer-QA/thlDigital_TechnicalAssesment.git

