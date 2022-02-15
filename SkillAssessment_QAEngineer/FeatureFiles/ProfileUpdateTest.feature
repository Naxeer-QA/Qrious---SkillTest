Feature: ProfileUpdate
	As a logged in user
	I want to be able to update my personal details 
	and view them reflected on the profile page successfully

@smokeTest
Scenario: User updates profile
	Given the user is logged in with valid '<useRname>' and '<pasSword>' successfully
	When the user clicks on edit profile button
	Then the edit profile page is shown
	When the user edits '<emailAddress>', '<DateOfBirth>', '<newPassword>' and '<confirmPassword>
	And clicks on submit button
	Then the updated details are shown along with the '<successmessage>
	Examples: 
	| useRname | pasSword         |emailAddress          | DateOfBirth | newPassword     | confirmPassword |successmessage                                             |
	| ubiquity | P@ss123#UbiQuity |khannazeer8@gmail.com | 08/09/2000  | mother#UbiQuity | mother#UbiQuity |Update is successful! Please see updated information below |
