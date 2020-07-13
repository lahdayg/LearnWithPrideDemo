Feature: DataDrivenWithExamples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Examples
	Given I navigate to this website "https://angularjs.realworld.io/#/register"
	When I enter username text "<Username>"
	And I enter Email text "<Email>"
	And I enter Password text "<Password>"
	And I click on Sign up button
	Then I am logged in with my username displayed


	Examples: 
	| Username | Email | Password |
	| Demo3    | Demo3 | PasswordSecure@ |
	| Demo2    | Demo2 | PasswordSecure2 |