Feature: IframeHandling
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Iframe Handling
	Given I navigate to this website "https://www.qa.giftrete.com"
	And I click on Sign in
	And I enter my email address "lahdayg@yahoo.com"
	And I enter my password "12345"
	When I click on Sign in
	And I click on post item
	And I enter item description
	And I enter item name
	And I click on choose file
	#Then the result should be 120