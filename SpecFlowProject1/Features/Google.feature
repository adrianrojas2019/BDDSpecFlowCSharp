@E2E
Feature: Search in Google Home Page

# Test comment in Google Feature File
Background: 
	Given Google Page Open
	And Search Text Box should be present and Enabled in the Google Home Page

Scenario Outline: Search in Google Home Page with different keywords
	When User searches a Course with a keyword <keyword> Tutorial
	And Hit enters button
	Then All Courses related to <keyword> Tutorial should be displayed
	
	@Smoke @Application1
	Examples: 
		| keyword  |
		| Java     |
	@Regression @Application2
	Examples: 
		| keyword  |
		| SpecFlow |
	@UAT @Application3
	Examples: 
		| keyword  |
		| Selenium |