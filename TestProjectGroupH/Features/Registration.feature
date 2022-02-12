Feature: Registration
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sign up
	And I enter my Username
	And I enter my Email
	And I enter my Password
	When I click on the sign up button
	Then I should be able to register successfully