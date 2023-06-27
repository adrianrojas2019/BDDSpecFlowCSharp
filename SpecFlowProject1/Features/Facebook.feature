Feature: Facebook Home Page Login

//@ignore attribute in order to ignore any scenario
@Smoke @Regression @Application1 @Application2
Scenario: To check the login functionality for the Facebook Home Page with invalid Credentials
	Given User Navigates to the Facebook Home Page
	When User enters Test$#12343 as UserName and Pass1234 as Password
	And Click on the Login button
	Then Login should be unsuccessful
	