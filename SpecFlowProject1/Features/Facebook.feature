Feature: Facebook Home Page Login

//@ignore attribute in order to ignore any scenario
@Smoke @Regression @Application1 @Application2
Scenario Outline: To check the login functionality for the Facebook Home Page with invalid Credentials
	Given User Navigates to the Facebook Home Page
	When User enters <username> as UserName and <password> as Password
	And Click on the Login button
	Then Login should be unsuccessful

	Examples: 
	| username   | password |
	| Test$#123  | 1234     |
	| Test$#122  | 1235     |
	| Test$#125  | 1236     |